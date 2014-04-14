using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WiimoteDevice;
using Setting;

namespace WiiPC
{
    public partial class MainWindow : Form, IControllerChanger
    {
        private WiimoteDevice.Controller Wiimote = new WiimoteDevice.Controller();
        private IWiiController WorkingController;

        private WiimoteDevice.Controller Wiimote2 = new WiimoteDevice.Controller();
        private IWiiController WorkingController2;

        private WiimoteDevice.Controller Wiimote3 = new WiimoteDevice.Controller();
        private IWiiController WorkingController3;

        private WiimoteDevice.Controller Wiimote4 = new WiimoteDevice.Controller();
        private IWiiController WorkingController4;


        private int currentSetting = 1;
        private Popup.PopupMessage PopupMessage = new Popup.PopupMessage();

        private delegate void LabelTextDelegate(Label label, String text);
        private delegate void ToolStripProgressDelegate(ToolStripProgressBar bar, int value);

        private delegate void PopupDelegate(String text);

        private void SetLabelText(Label label, String text) {
            label.Text = text;
        }

        private void SetProgressValue(ToolStripProgressBar bar, int value) {
            bar.Value = value;
        }

        public MainWindow()
        {
            InitializeComponent();
            this.Wiimote.ButtonPress += new EventHandler<ButtonPressEventArgs>(Wiimote_ButtonPress);
            this.Wiimote.ButtonUp += new EventHandler<ButtonUpEventArgs>(Wiimote_ButtonUp);

            this.Wiimote2.ButtonPress += new EventHandler<ButtonPressEventArgs>(Wiimote_ButtonPress2);
            this.Wiimote2.ButtonUp += new EventHandler<ButtonUpEventArgs>(Wiimote_ButtonUp2);
            
            this.Wiimote3.ButtonPress += new EventHandler<ButtonPressEventArgs>(Wiimote_ButtonPress3);
            this.Wiimote3.ButtonUp += new EventHandler<ButtonUpEventArgs>(Wiimote_ButtonUp3);

            this.Wiimote4.ButtonPress += new EventHandler<ButtonPressEventArgs>(Wiimote_ButtonPress4);
            this.Wiimote4.ButtonUp += new EventHandler<ButtonUpEventArgs>(Wiimote_ButtonUp4);



            this.wiiController1.ControllerChanger = this;
            this.wiiController2.ControllerChanger = this;
            this.wiiController3.ControllerChanger = this;
            this.wiiController4.ControllerChanger = this;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            this.labelStatus.Text = "Disconnected";

            this.labelStatus2.Text = "Disconnected";
            this.labelStatus3.Text = "Disconnected";
            this.labelStatus4.Text = "Disconnected";

            ChangeController(1);
            this.LoadSetting(Setting.Loader.Load());
        }

        protected override void OnClosing(CancelEventArgs e) {
            this.Wiimote.Disconnect();

            this.Wiimote2.Disconnect();
            this.Wiimote3.Disconnect();
            this.Wiimote4.Disconnect();

            this.progressBattery.Value = 0;
            this.progressBattery2.Value = 0;
            this.progressBattery3.Value = 0;
            this.progressBattery4.Value = 0;
            
            base.OnClosing(e);
        }


        // 1

        void Wiimote_ButtonPress(object sender, ButtonPressEventArgs e) {
            this.BeginInvoke(new ToolStripProgressDelegate(SetProgressValue), progressBattery, (int)(this.Wiimote.Battery));
            WorkingController.ButtonPressHandler(e);
        }

        void Wiimote_ButtonUp(object sender, ButtonUpEventArgs e) {
            WorkingController.ButtonUpHandler(e);
        }


        // 2

        void Wiimote_ButtonPress2(object sender, ButtonPressEventArgs e)
        {
            this.BeginInvoke(new ToolStripProgressDelegate(SetProgressValue), progressBattery2, (int)(this.Wiimote2.Battery));
            WorkingController2.ButtonPressHandler(e);
        }

        void Wiimote_ButtonUp2(object sender, ButtonUpEventArgs e)
        {
            WorkingController2.ButtonUpHandler(e);
        }


        // 3

        void Wiimote_ButtonPress3(object sender, ButtonPressEventArgs e)
        {
            this.BeginInvoke(new ToolStripProgressDelegate(SetProgressValue), progressBattery3, (int)(this.Wiimote3.Battery));
            WorkingController3.ButtonPressHandler(e);
        }

        void Wiimote_ButtonUp3(object sender, ButtonUpEventArgs e)
        {
            WorkingController3.ButtonUpHandler(e);
        }

        // 4

        void Wiimote_ButtonPress4(object sender, ButtonPressEventArgs e)
        {
            this.BeginInvoke(new ToolStripProgressDelegate(SetProgressValue), progressBattery4, (int)(this.Wiimote4.Battery));
            WorkingController4.ButtonPressHandler(e);
        }

        void Wiimote_ButtonUp4(object sender, ButtonUpEventArgs e)
        {
            WorkingController4.ButtonUpHandler(e);
        }


        private void ReflectLED() {
            if (this.displaySettingLightToolStripMenuItem.Checked == false) {
                Wiimote.SetLED(false, false, false, false);
                Wiimote2.SetLED(false, false, false, false);
            } else {
                if (Wiimote2.isConnected() == Wiimote3.isConnected() == Wiimote4.isConnected() == false)
                {
                    Wiimote.SetLED(currentSetting == 1, currentSetting == 2, currentSetting == 3, currentSetting == 4);
                }
                else
                {
                    if (true == Wiimote2.isConnected())
                    {
                        Wiimote2.SetLED(false, true, false, false);
                    }

                    if (true == Wiimote3.isConnected())
                    {
                        Wiimote3.SetLED(false, false, true, false);
                    }

                    if (true == Wiimote4.isConnected())
                    {
                        Wiimote4.SetLED(false, false, false, true);
                    }
                }
               
            }
        }

        private void connectCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {

                this.Wiimote.Connect();
                this.Wiimote.SetRumble(500);

                this.Wiimote2.Connect();
                this.Wiimote2.SetRumble(500);
                
                this.Wiimote3.Connect();
                this.Wiimote3.SetRumble(500);

                this.Wiimote4.Connect();
                this.Wiimote4.SetRumble(500);



                this.connectCToolStripMenuItem.Enabled = false;
                this.disconnectToolStripMenuItem.Enabled = true;
              
                this.progressBattery.Value = (int)(this.Wiimote.Battery);
                this.progressBattery2.Value = (int)(this.Wiimote2.Battery);
                this.progressBattery3.Value = (int)(this.Wiimote3.Battery);
                this.progressBattery4.Value = (int)(this.Wiimote4.Battery);

                if (this.Wiimote.isConnected() && this.displaySettingLightToolStripMenuItem.Checked == true) {
                    this.labelStatus.Text = "Connected";

                    if (this.Wiimote2.isConnected() == false && this.Wiimote3.isConnected() == false && this.Wiimote4.isConnected() == false)
                    {
                        // One controller mode
                        Wiimote.SetLED(currentSetting == 1, currentSetting == 2, currentSetting == 3, currentSetting == 4);
                    }
                    else
                    {
                        this.Wiimote.SetLED(true, false, false, false);
                    }
                }


                if (this.Wiimote2.isConnected() && this.displaySettingLightToolStripMenuItem.Checked == true)
                {
                    this.labelStatus2.Text = "Connected";
                    this.Wiimote2.SetLED(false, true, false, false);
                }

                if (this.Wiimote3.isConnected() && this.displaySettingLightToolStripMenuItem.Checked == true)
                {
                    this.labelStatus3.Text = "Connected";
                    this.Wiimote3.SetLED(false, false, true, false);
                }

                if (this.Wiimote4.isConnected() && this.displaySettingLightToolStripMenuItem.Checked == true)
                {
                    this.labelStatus4.Text = "Connected";
                    this.Wiimote4.SetLED(false, false, false, true);
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Connect Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Wiimote.Disconnect();
            this.Wiimote2.Disconnect();
            this.Wiimote3.Disconnect();
            this.Wiimote4.Disconnect();

            this.progressBattery.Value = 0;
            this.progressBattery2.Value = 0;
            this.progressBattery3.Value = 0;
            this.progressBattery4.Value = 0;


            this.connectCToolStripMenuItem.Enabled = true;
            this.disconnectToolStripMenuItem.Enabled = false;

            this.labelStatus.Text = "Disconnected";
            this.labelStatus2.Text = "Disconnected";
            this.labelStatus3.Text = "Disconnected";
            this.labelStatus4.Text = "Disconnected";
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        public void ChangeController(int controllerNum) {
            this.currentSetting = controllerNum;
            switch (controllerNum) {
                case 1: 
                    this.Invoke(new LabelTextDelegate(SetLabelText), labelSetting, "Setting 1"); 
                    if(this.displaySettingChangedDToolStripMenuItem.Checked == true) {
                        ShowPopup("Setting 1");
                    }

                    this.WorkingController = wiiController1;
                    this.WorkingController2 = wiiController2;
                    this.WorkingController3 = wiiController3;
                    this.WorkingController4 = wiiController4;

                    this.labelW1.Text = "W1 (Setting1):";
                    this.labelW2.Text = "W2 (Setting2):";
                    this.labelW3.Text = "W3 (Setting3):";
                    this.labelW4.Text = "W4 (Setting4):";

                    break;
                case 2: 
                    this.Invoke(new LabelTextDelegate(SetLabelText), labelSetting, "Setting 2"); 
                    if(this.displaySettingChangedDToolStripMenuItem.Checked == true) {
                        ShowPopup("Setting 2");

                        this.WorkingController = wiiController2;
                        this.WorkingController2 = wiiController3;
                        this.WorkingController3 = wiiController4;
                        this.WorkingController4 = wiiController1;

                        this.labelW1.Text = "W1 (Setting2):";
                        this.labelW2.Text = "W2 (Setting3):";
                        this.labelW3.Text = "W3 (Setting4):";
                        this.labelW4.Text = "W4 (Setting1):";
                    }
                    break;
                case 3: 
                    this.Invoke(new LabelTextDelegate(SetLabelText), labelSetting, "Setting 3");
                    if(this.displaySettingChangedDToolStripMenuItem.Checked == true) {
                        ShowPopup("Setting 3");

                        this.WorkingController = wiiController3;
                        this.WorkingController2 = wiiController4;
                        this.WorkingController3 = wiiController1;
                        this.WorkingController4 = wiiController2;

                        this.labelW1.Text = "W1 (Setting3):";
                        this.labelW2.Text = "W2 (Setting4):";
                        this.labelW3.Text = "W3 (Setting1):";
                        this.labelW4.Text = "W4 (Setting2):";
                    }
                    break;
                case 4: 
                    this.Invoke(new LabelTextDelegate(SetLabelText), labelSetting, "Setting 4"); 
                    if(this.displaySettingChangedDToolStripMenuItem.Checked == true) {
                        ShowPopup("Setting 4");

                        this.WorkingController = wiiController4;
                        this.WorkingController2 = wiiController1;
                        this.WorkingController3 = wiiController2;
                        this.WorkingController4 = wiiController3;

                        this.labelW1.Text = "W1 (Setting4):";
                        this.labelW2.Text = "W2 (Setting1):";
                        this.labelW3.Text = "W3 (Setting2):";
                        this.labelW4.Text = "W4 (Setting3):";
                    }
                    break;
            }

            ReflectLED();
        }

        private void displaySettingChangedDToolStripMenuItem_Click(object sender, EventArgs e) {
            // 미구현
        }

        private void displaySettingLightToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {
            ReflectLED();
        }

        private void displaySettingLightToolStripMenuItem_Click(object sender, EventArgs e) {
            this.displaySettingLightToolStripMenuItem.Checked = !this.displaySettingLightToolStripMenuItem.Checked;
        }

        private void exitXToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Wiimote.Disconnect();
            this.Close();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void displaySettingChangedDToolStripMenuItem_Click_1(object sender, EventArgs e) {
            this.displaySettingChangedDToolStripMenuItem.Checked = !this.displaySettingChangedDToolStripMenuItem.Checked;
        }

        private void saveAllSettingSToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Setting.Saver.Save(ToWiimoteSetting()) == true) {
                MessageBox.Show("Success", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Fail", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPopup(String msg) {
            this.BeginInvoke(new PopupDelegate(PopupMessage.Show), msg);
        }

        public WiimoteSetting ToWiimoteSetting() {
            WiimoteSetting setting = new WiimoteSetting(
                this.displaySettingChangedDToolStripMenuItem.Checked,
                this.displaySettingLightToolStripMenuItem.Checked,
                wiiController1.ToControllerSetting(1),
                wiiController2.ToControllerSetting(2),
                wiiController3.ToControllerSetting(3),
                wiiController4.ToControllerSetting(4)
                );
            return setting;
        }


        public void LoadSetting(WiimoteSetting setting) {
            try {
                this.displaySettingChangedDToolStripMenuItem.Checked = setting.DisplaySettingChanging;
                this.displaySettingLightToolStripMenuItem.Checked = setting.DisplayLED;
                
                wiiController1.LoadSetting(setting.Controller[0]);
                wiiController2.LoadSetting(setting.Controller[1]);
                wiiController3.LoadSetting(setting.Controller[2]);
                wiiController4.LoadSetting(setting.Controller[3]);

            } catch (Exception) {
                MessageBox.Show("Fail to load setting.", "Load setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e) {
            new AboutBox1().ShowDialog();
        }


        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            if (this.WindowState == FormWindowState.Minimized) {
                this.Visible = false;
            }
        }
    }
}
