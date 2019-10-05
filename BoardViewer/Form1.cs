using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace BoardViewer
{

	public partial class Form1 : Form
	{
		SerialPort mySerialPort;
		private string combo_default_item = "Select COM port";
		private bool is_connected;
		private int word_length = 7;
		char start_char = 'S';
		Board[] board_array;
		char[] ids = { '0', '1', '2', '3', '4', '5', '6', '7' };
		RichTextBox[] board_disp_array;
		int index_to_draw;
		bool must_redraw;
		private enum AngleType{
			ROLL_DATA,
			PITCH_DATA,
			YAW_DATA
		}

		private struct RXData{
			public char id;
			public AngleType angle;
			public int sign;
			public int value;
			public bool valid;
		}

		public Form1() {
			InitializeComponent();
			InitComComboBox();

			// crear las 8 boards
			board_array = new Board[8];
			for(int i = 0; i < 8; i++) {
				board_array[i] = new Board(ids[i]);
			}

			board_disp_array = new RichTextBox[8];
			board_disp_array[0] = richTextBox0;
			board_disp_array[1] = richTextBox1;
			board_disp_array[2] = richTextBox2;
			board_disp_array[3] = richTextBox3;
			board_disp_array[4] = richTextBox4;
			board_disp_array[5] = richTextBox5;
			board_disp_array[6] = richTextBox6;
			board_disp_array[7] = richTextBox7;

			foreach(RichTextBox control in board_disp_array) {
				control.Multiline = true;
			}
		}

		private void InitComComboBox() {
			comComboBox.Items.Clear();
			comComboBox.Items.Add(combo_default_item);
			comComboBox.SelectedIndex = 0;
		}

		private void ComComboBox_Click(object sender, EventArgs e) {
			// clear combo box
			comComboBox.Items.Clear();
			comComboBox.Items.Add(combo_default_item);
			comComboBox.SelectedIndex = 0;
			// update ports
			string[] com_names = SerialPort.GetPortNames();

			// list ports
			foreach (string name in com_names) {
				comComboBox.Items.Add(name);
			}
		}

		private void ComComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			// check if any COM slected
			connectButton.Enabled = (!(comComboBox.SelectedIndex == 0));
		
		}

		private void ConnectButton_Click(object sender, EventArgs e) {
			string port_name = comComboBox.SelectedItem.ToString();
			Int32 baud_rate = Convert.ToInt32(baudRateNumeric.Value);
			// TODO: hacer dinamica la seleccion del paridad y stopbit
			Parity parity = new Parity();
			if (evenParity.Checked) {
				parity = Parity.Even;
			} else if (oddParity.Checked) {
				parity = Parity.Odd;
			} else if(noneParity.Checked){
				parity = Parity.None;
			}

			StopBits stop_bits = new StopBits();

			if (stopBit1.Checked) {
				stop_bits = StopBits.One;
			} else if (stopBit15.Checked) {
				stop_bits = StopBits.OnePointFive;
			} else if (stopBit2.Checked) {
				stop_bits = StopBits.Two;
			}
			
			Int32 data_bits = 8;
			if (radioButton8bits.Checked) {
				data_bits = 8; 
			}else if (radioButton9bits.Checked) {
				data_bits = 9;
			}

			try {
				is_connected = false;
				mySerialPort = new SerialPort(port_name, baud_rate, parity, data_bits, stop_bits);
				mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceiveHandler);
				mySerialPort.ReceivedBytesThreshold = word_length;
				mySerialPort.Open();
				redrawTimer.Enabled = true;
				redrawTimer.Start();
				is_connected = true;
			} catch {
				is_connected = false;
			}
			connectButton.Enabled = !is_connected;
			disconnectButton.Enabled = is_connected;
		}

		private RXData RXDataParser(string rx_data) {
			// verifiar que tenga length adecuado:
			RXData ret = new RXData();
			bool valid = true;
			valid = (rx_data.Length == word_length);
			ret.value = 0;
			ret.angle = AngleType.ROLL_DATA;
			ret.valid = false;
			if (valid) {
				if (rx_data[0] == start_char) {
					if (rx_data[1] >= '0' && rx_data[1] <= '7') {
						ret.id = rx_data[1];
						int value = 0;
						try {
							value = Convert.ToInt32(rx_data.Substring(4, 3));
						} catch {
							valid = false;
						}
						if ((value <= 180 && value >= -180) && valid) {
							ret.value = value;
							switch (rx_data[2]) {
								case 'R':
									ret.angle = AngleType.ROLL_DATA;
									break;
								case 'C':
									ret.angle = AngleType.PITCH_DATA;
									break;
								case 'O':
									ret.angle = AngleType.YAW_DATA;
									break;
								default:
									valid = false;
									break;
							}
							if (rx_data[3] == '+' || rx_data[3] == '-') {
								ret.sign = (rx_data[3] == '+') ? 1 : -1;
								ret.valid = valid;
							} else
								valid = false;
						}else
								valid = false;
					}else
							valid = false;
				} else
						valid = false;
			} else
					valid = false;
			ret.valid = valid;
			return ret;
		}
			
		private void DataReceiveHandler(object sender, SerialDataReceivedEventArgs args) {
			SerialPort port = (SerialPort)sender;
			byte[] rx_data = new byte[word_length];
			port.Read(rx_data,0,word_length);
			port.DiscardInBuffer();
			string rx_data_str = Encoding.UTF8.GetString(rx_data, 0, rx_data.Length);
			RXData board_data = RXDataParser(rx_data_str);
			if (board_data.valid) {
				UpdateBoard(board_data);
			}
			
		}

		private void UpdateBoard(RXData board_data) {
			// verificar si el id esta en el array de ids;
			int index = Array.IndexOf(ids, board_data.id);
			bool valid = true;
			if (index > -1) {
				switch (board_data.angle) {
					case AngleType.ROLL_DATA:
						board_array[index].Roll = board_data.sign * board_data.value;
						break;
					case AngleType.PITCH_DATA:
						board_array[index].Pitch = board_data.sign * board_data.value;
						break;
					case AngleType.YAW_DATA:
						board_array[index].Yaw = board_data.sign * board_data.value;
						break;
					default:
						valid = false;
						break;
				}
				must_redraw = valid;
				index_to_draw = index;
			}
		}

		private void RedrawBoard(int _index) {
			string[] lines = new string[3];

			string roll_value = Convert.ToString(board_array[_index].Roll);
			string pitch_value = Convert.ToString(board_array[_index].Pitch);
			string yaw_value = Convert.ToString(board_array[_index].Yaw);

			lines[0] = "Roll: " + roll_value;
			lines[1] = "Pitch: " + pitch_value;
			lines[2] = "Yaw: " + yaw_value;

			board_disp_array[_index].Lines = lines;
		}

		private void RedrawTimer_Tick(object sender, EventArgs e) {
			if (must_redraw && is_connected) {
				RedrawBoard(index_to_draw);
			}
		}

		private void DisconnectButton_Click(object sender, EventArgs e) {
			if (is_connected) {
				if (mySerialPort.IsOpen) {
					mySerialPort.Close();
					mySerialPort.Dispose();
					is_connected = false;
					comComboBox.SelectedIndex = 0;
					connectButton.Enabled = false;
					disconnectButton.Enabled = false;

					// clear all displays.
					foreach(RichTextBox control in board_disp_array) {
						control.Clear();
					}
				}
			}
		}
	}
}
