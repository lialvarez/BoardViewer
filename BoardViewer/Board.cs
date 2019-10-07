using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardViewer
{
	class Board
	{
		private char _id;

		public char Id {
			get { return _id; }
			set { _id = value; }
		}

		private bool _enabled;

		public bool Enabled {
			get { return _enabled; }
			set { _enabled = value; }
		}

		private int _roll;

		public int Roll {
			get { return _roll; }
			set { _roll = value; }
		}

		private int _pitch;

		public int Pitch {
			get { return _pitch; }
			set { _pitch = value; }
		}

		private int _yaw;

		public int Yaw {
			get { return _yaw; }
			set { _yaw = value; }
		}

		public Board(char _board_id, int _board_roll = 0, int _board_pitch = 0, int _board_yaw = 0) {
			_id = _board_id;
			_roll = _board_roll;
			_pitch = _board_pitch;
			_yaw = _board_pitch;
			_enabled = false;
		}

	}
}
