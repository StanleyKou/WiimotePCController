using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using WiiPC.Command;
using WiimoteDevice;
using Setting;

namespace WiiPC
{
    public partial class WiiKeySelector : UserControl
    {
        public String WiimoteKeyText { get { return this.WiimoteKey.Text; } set { this.WiimoteKey.Text = value; } }
        public String WindowsKeyText { get { return this.WindowsKey.Text; } set { this.WindowsKey.Text = value; } }
        public String MouseKeyText { get { return this.MouseKey.Text; } set { this.MouseKey.Text = value; } }
        public String SystemKeyText { get { return this.SystemKey.Text; } set { this.SystemKey.Text = value; } }

        public CommandFactory.Types CommandType { get; private set; }
        public delegate int KeyCodeDelegate(CommandFactory.Types type);

        public int KeyCode {
            get {
                return (int)this.Invoke(new KeyCodeDelegate(GetKeyCode), this.CommandType);
            }
        }

        public int GetKeyCode(CommandFactory.Types type) {
            switch (this.CommandType) {
                case CommandFactory.Types.KeyInput: return this.WindowsKey.KeyCode;
                case CommandFactory.Types.MouseMove: return this.MouseKey.KeyCode;
                case CommandFactory.Types.SystemFunction: return this.SystemKey.KeyCode;
                default: return 0;
            }
        }

        public int SelectedIndex {
            get {
                switch (this.CommandType) {
                    case CommandFactory.Types.KeyInput: return this.WindowsKey.SelectedIndex;
                    case CommandFactory.Types.MouseMove: return this.MouseKey.SelectedIndex;
                    case CommandFactory.Types.SystemFunction: return this.SystemKey.SelectedIndex;
                    default: return 0;
                }
            }
            set {
                switch (this.CommandType) {
                    case CommandFactory.Types.KeyInput: this.WindowsKey.SelectedIndex = value; break;
                    case CommandFactory.Types.MouseMove: this.MouseKey.SelectedIndex = value; break;
                    case CommandFactory.Types.SystemFunction: this.SystemKey.SelectedIndex = value; break;
                }
            }
        }

        public WiiKeySelector()
        {
            InitializeComponent();
            CommandType = CommandFactory.Types.KeyInput;

            WindowsKey.SelectedIndexChanged += new EventHandler(WindowsKey_SelectedIndexChanged);
            MouseKey.SelectedIndexChanged += new EventHandler(MouseKey_SelectedIndexChanged);
            SystemKey.SelectedIndexChanged += new EventHandler(SystemKey_SelectedIndexChanged);
        }


        void WindowsKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WindowsKey.SelectedIndex != 0)
            {
                SystemKey.SelectedIndex = 0;
                MouseKey.SelectedIndex = 0;
            }
            this.CommandType = CommandFactory.Types.KeyInput;
        }

        void MouseKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MouseKey.SelectedIndex != 0)
            {
                WindowsKey.SelectedIndex = 0;
                SystemKey.SelectedIndex = 0;
            }
            this.CommandType = CommandFactory.Types.MouseMove;
        }

        void SystemKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SystemKey.SelectedIndex != 0)
            {
                WindowsKey.SelectedIndex = 0;
                MouseKey.SelectedIndex = 0;
            }
            this.CommandType = CommandFactory.Types.SystemFunction;
        }


        public void Check(bool check) {
            this.WiimoteKey.Checked = check;
        }

        public void Select(CommandFactory.Types commandType, int index) {
            CommandType = commandType;
            SelectedIndex = index;
        }

        public KeyMap ToKeyMap() {
            return new KeyMap((int)CommandType, this.SelectedIndex);
        }

        public void LoadKeyMap(KeyMap map) {
            Select((CommandFactory.Types)map.CommandType, map.Index);
        }
    }
}

