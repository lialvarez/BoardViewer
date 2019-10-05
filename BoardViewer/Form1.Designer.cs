namespace BoardViewer
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.configPanel = new System.Windows.Forms.Panel();
			this.disconnectButton = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label13 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.noneParity = new System.Windows.Forms.RadioButton();
			this.evenParity = new System.Windows.Forms.RadioButton();
			this.oddParity = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioButton9bits = new System.Windows.Forms.RadioButton();
			this.radioButton8bits = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.baudRateNumeric = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.connectButton = new System.Windows.Forms.Button();
			this.configLabel = new System.Windows.Forms.Label();
			this.comComboBox = new System.Windows.Forms.ComboBox();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.richTextBox7 = new System.Windows.Forms.RichTextBox();
			this.richTextBox6 = new System.Windows.Forms.RichTextBox();
			this.richTextBox5 = new System.Windows.Forms.RichTextBox();
			this.richTextBox4 = new System.Windows.Forms.RichTextBox();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.richTextBox0 = new System.Windows.Forms.RichTextBox();
			this.redrawTimer = new System.Windows.Forms.Timer(this.components);
			this.configPanel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.baudRateNumeric)).BeginInit();
			this.mainPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// configPanel
			// 
			this.configPanel.Controls.Add(this.disconnectButton);
			this.configPanel.Controls.Add(this.panel3);
			this.configPanel.Controls.Add(this.label13);
			this.configPanel.Controls.Add(this.panel2);
			this.configPanel.Controls.Add(this.label4);
			this.configPanel.Controls.Add(this.panel1);
			this.configPanel.Controls.Add(this.label3);
			this.configPanel.Controls.Add(this.baudRateNumeric);
			this.configPanel.Controls.Add(this.label2);
			this.configPanel.Controls.Add(this.label1);
			this.configPanel.Controls.Add(this.connectButton);
			this.configPanel.Controls.Add(this.configLabel);
			this.configPanel.Controls.Add(this.comComboBox);
			this.configPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.configPanel.Location = new System.Drawing.Point(0, 0);
			this.configPanel.Name = "configPanel";
			this.configPanel.Padding = new System.Windows.Forms.Padding(5);
			this.configPanel.Size = new System.Drawing.Size(243, 503);
			this.configPanel.TabIndex = 0;
			// 
			// disconnectButton
			// 
			this.disconnectButton.Enabled = false;
			this.disconnectButton.Location = new System.Drawing.Point(12, 453);
			this.disconnectButton.Name = "disconnectButton";
			this.disconnectButton.Size = new System.Drawing.Size(223, 23);
			this.disconnectButton.TabIndex = 13;
			this.disconnectButton.Text = "Disconnect";
			this.disconnectButton.UseVisualStyleBackColor = true;
			this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
			// 
			// panel3
			// 
			this.panel3.AutoSize = true;
			this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel3.Controls.Add(this.radioButton1);
			this.panel3.Controls.Add(this.radioButton2);
			this.panel3.Controls.Add(this.radioButton3);
			this.panel3.Location = new System.Drawing.Point(15, 333);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(55, 84);
			this.panel3.TabIndex = 12;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(3, 60);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(37, 21);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.Text = "2";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(3, 32);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(49, 21);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "1.5";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Checked = true;
			this.radioButton3.Location = new System.Drawing.Point(3, 3);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(37, 21);
			this.radioButton3.TabIndex = 0;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "1";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(12, 313);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(57, 17);
			this.label13.TabIndex = 11;
			this.label13.Text = "Stop Bit";
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel2.Controls.Add(this.noneParity);
			this.panel2.Controls.Add(this.evenParity);
			this.panel2.Controls.Add(this.oddParity);
			this.panel2.Location = new System.Drawing.Point(15, 226);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(69, 84);
			this.panel2.TabIndex = 10;
			// 
			// noneParity
			// 
			this.noneParity.AutoSize = true;
			this.noneParity.Checked = true;
			this.noneParity.Location = new System.Drawing.Point(3, 60);
			this.noneParity.Name = "noneParity";
			this.noneParity.Size = new System.Drawing.Size(63, 21);
			this.noneParity.TabIndex = 2;
			this.noneParity.TabStop = true;
			this.noneParity.Text = "None";
			this.noneParity.UseVisualStyleBackColor = true;
			// 
			// evenParity
			// 
			this.evenParity.AutoSize = true;
			this.evenParity.Location = new System.Drawing.Point(3, 32);
			this.evenParity.Name = "evenParity";
			this.evenParity.Size = new System.Drawing.Size(61, 21);
			this.evenParity.TabIndex = 1;
			this.evenParity.Text = "Even";
			this.evenParity.UseVisualStyleBackColor = true;
			// 
			// oddParity
			// 
			this.oddParity.AutoSize = true;
			this.oddParity.Location = new System.Drawing.Point(3, 3);
			this.oddParity.Name = "oddParity";
			this.oddParity.Size = new System.Drawing.Size(56, 21);
			this.oddParity.TabIndex = 0;
			this.oddParity.Text = "Odd";
			this.oddParity.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Parity";
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.radioButton9bits);
			this.panel1.Controls.Add(this.radioButton8bits);
			this.panel1.Location = new System.Drawing.Point(12, 143);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(69, 56);
			this.panel1.TabIndex = 8;
			// 
			// radioButton9bits
			// 
			this.radioButton9bits.AutoSize = true;
			this.radioButton9bits.Location = new System.Drawing.Point(3, 32);
			this.radioButton9bits.Name = "radioButton9bits";
			this.radioButton9bits.Size = new System.Drawing.Size(63, 21);
			this.radioButton9bits.TabIndex = 1;
			this.radioButton9bits.Text = "9 bits";
			this.radioButton9bits.UseVisualStyleBackColor = true;
			// 
			// radioButton8bits
			// 
			this.radioButton8bits.AutoSize = true;
			this.radioButton8bits.Checked = true;
			this.radioButton8bits.Location = new System.Drawing.Point(3, 3);
			this.radioButton8bits.Name = "radioButton8bits";
			this.radioButton8bits.Size = new System.Drawing.Size(63, 21);
			this.radioButton8bits.TabIndex = 0;
			this.radioButton8bits.TabStop = true;
			this.radioButton8bits.Text = "8 bits";
			this.radioButton8bits.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Word Length";
			// 
			// baudRateNumeric
			// 
			this.baudRateNumeric.Location = new System.Drawing.Point(12, 97);
			this.baudRateNumeric.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
			this.baudRateNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.baudRateNumeric.Name = "baudRateNumeric";
			this.baudRateNumeric.Size = new System.Drawing.Size(223, 22);
			this.baudRateNumeric.TabIndex = 6;
			this.baudRateNumeric.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Baud Rate";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "COM Port Selection";
			// 
			// connectButton
			// 
			this.connectButton.Enabled = false;
			this.connectButton.Location = new System.Drawing.Point(12, 423);
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(223, 23);
			this.connectButton.TabIndex = 2;
			this.connectButton.Text = "Connect";
			this.connectButton.UseVisualStyleBackColor = true;
			this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
			// 
			// configLabel
			// 
			this.configLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.configLabel.AutoSize = true;
			this.configLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.configLabel.Location = new System.Drawing.Point(9, 9);
			this.configLabel.Name = "configLabel";
			this.configLabel.Size = new System.Drawing.Size(159, 17);
			this.configLabel.TabIndex = 1;
			this.configLabel.Text = "Device Configuration";
			// 
			// comComboBox
			// 
			this.comComboBox.FormattingEnabled = true;
			this.comComboBox.Location = new System.Drawing.Point(12, 50);
			this.comComboBox.Name = "comComboBox";
			this.comComboBox.Size = new System.Drawing.Size(223, 24);
			this.comComboBox.TabIndex = 0;
			this.comComboBox.SelectedIndexChanged += new System.EventHandler(this.ComComboBox_SelectedIndexChanged);
			this.comComboBox.Click += new System.EventHandler(this.ComComboBox_Click);
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.tableLayoutPanel1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(243, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Padding = new System.Windows.Forms.Padding(3);
			this.mainPanel.Size = new System.Drawing.Size(827, 503);
			this.mainPanel.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.richTextBox7, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.richTextBox6, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.richTextBox5, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.richTextBox4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.richTextBox3, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.richTextBox2, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label8, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label10, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label11, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.label12, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.richTextBox0, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(821, 497);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// richTextBox7
			// 
			this.richTextBox7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox7.Location = new System.Drawing.Point(619, 276);
			this.richTextBox7.Name = "richTextBox7";
			this.richTextBox7.Size = new System.Drawing.Size(198, 217);
			this.richTextBox7.TabIndex = 15;
			this.richTextBox7.Text = "";
			// 
			// richTextBox6
			// 
			this.richTextBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox6.Location = new System.Drawing.Point(414, 276);
			this.richTextBox6.Name = "richTextBox6";
			this.richTextBox6.Size = new System.Drawing.Size(198, 217);
			this.richTextBox6.TabIndex = 14;
			this.richTextBox6.Text = "";
			// 
			// richTextBox5
			// 
			this.richTextBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox5.Location = new System.Drawing.Point(209, 276);
			this.richTextBox5.Name = "richTextBox5";
			this.richTextBox5.Size = new System.Drawing.Size(198, 217);
			this.richTextBox5.TabIndex = 13;
			this.richTextBox5.Text = "";
			// 
			// richTextBox4
			// 
			this.richTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox4.Location = new System.Drawing.Point(4, 276);
			this.richTextBox4.Name = "richTextBox4";
			this.richTextBox4.Size = new System.Drawing.Size(198, 217);
			this.richTextBox4.TabIndex = 12;
			this.richTextBox4.Text = "";
			// 
			// richTextBox3
			// 
			this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox3.Location = new System.Drawing.Point(619, 29);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(198, 215);
			this.richTextBox3.TabIndex = 11;
			this.richTextBox3.Text = "";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox2.Location = new System.Drawing.Point(414, 29);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(198, 215);
			this.richTextBox2.TabIndex = 10;
			this.richTextBox2.Text = "";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(209, 29);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(198, 215);
			this.richTextBox1.TabIndex = 9;
			this.richTextBox1.Text = "";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(619, 1);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(198, 24);
			this.label8.TabIndex = 3;
			this.label8.Text = "Board 3";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(414, 1);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(198, 24);
			this.label7.TabIndex = 2;
			this.label7.Text = "Board 2";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(209, 1);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(198, 24);
			this.label6.TabIndex = 1;
			this.label6.Text = "Board 1";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(4, 1);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(198, 24);
			this.label5.TabIndex = 0;
			this.label5.Text = "Board 0";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(4, 248);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(198, 24);
			this.label9.TabIndex = 4;
			this.label9.Text = "Board 4";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(209, 248);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(198, 24);
			this.label10.TabIndex = 5;
			this.label10.Text = "Board 5";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(414, 248);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(198, 24);
			this.label11.TabIndex = 6;
			this.label11.Text = "Board 6";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(619, 248);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(198, 24);
			this.label12.TabIndex = 7;
			this.label12.Text = "Board 7";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// richTextBox0
			// 
			this.richTextBox0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox0.Location = new System.Drawing.Point(4, 29);
			this.richTextBox0.Name = "richTextBox0";
			this.richTextBox0.Size = new System.Drawing.Size(198, 215);
			this.richTextBox0.TabIndex = 8;
			this.richTextBox0.Text = "";
			// 
			// redrawTimer
			// 
			this.redrawTimer.Tick += new System.EventHandler(this.RedrawTimer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1070, 503);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.configPanel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.configPanel.ResumeLayout(false);
			this.configPanel.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.baudRateNumeric)).EndInit();
			this.mainPanel.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel configPanel;
		private System.Windows.Forms.Label configLabel;
		private System.Windows.Forms.ComboBox comComboBox;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button connectButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown baudRateNumeric;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton evenParity;
		private System.Windows.Forms.RadioButton oddParity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radioButton9bits;
		private System.Windows.Forms.RadioButton radioButton8bits;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton noneParity;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.RichTextBox richTextBox7;
		private System.Windows.Forms.RichTextBox richTextBox6;
		private System.Windows.Forms.RichTextBox richTextBox5;
		private System.Windows.Forms.RichTextBox richTextBox4;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox0;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Timer redrawTimer;
		private System.Windows.Forms.Button disconnectButton;
	}
}

