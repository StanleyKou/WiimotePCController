using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using WiimoteDevice;
using WiiPC.Command;
using Setting;


namespace WiiPC
{
    public partial class WiiController : UserControl, IWiiController
    {
        private delegate void CheckDelegate(WiiKeySelector controller, bool check);
        public IControllerChanger ControllerChanger { get; set; }
        public int No { get; set; }

        public WiiController()
        {
            InitializeComponent();
            SetDefault();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }

        private void Check(WiiKeySelector controller, bool check) {
            controller.Check(check);
        }

        public void ButtonPressHandler(ButtonPressEventArgs e)
        {
            switch (e.Button) {
                case WiimoteDevice.Controller.Buttons.Up:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorUp, true);
                    CommandFactory.Create(wiiKeySelectorUp.CommandType, wiiKeySelectorUp.KeyCode, true, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.Down:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorDown, true);
                    CommandFactory.Create(wiiKeySelectorDown.CommandType, wiiKeySelectorDown.KeyCode, true, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.Left:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorLeft, true);
                    CommandFactory.Create(wiiKeySelectorLeft.CommandType, wiiKeySelectorLeft.KeyCode, true, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.Right:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorRight, true);
                    CommandFactory.Create(wiiKeySelectorRight.CommandType, wiiKeySelectorRight.KeyCode, true, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.A:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorA, true);
                    CommandFactory.Create(wiiKeySelectorA.CommandType, wiiKeySelectorA.KeyCode, true, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.B:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorB, true);
                    CommandFactory.Create(wiiKeySelectorB.CommandType, wiiKeySelectorB.KeyCode, true, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.Plus:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorPlus, true);
                    CommandFactory.Create(wiiKeySelectorPlus.CommandType, wiiKeySelectorPlus.KeyCode, true, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.Home:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorHome, true);
                    CommandFactory.Create(wiiKeySelectorHome.CommandType, wiiKeySelectorHome.KeyCode, true, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.Minus:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorMinus, true);
                    CommandFactory.Create(wiiKeySelectorMinus.CommandType, wiiKeySelectorMinus.KeyCode, true, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.One:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorOne, true);
                    CommandFactory.Create(wiiKeySelectorOne.CommandType, wiiKeySelectorOne.KeyCode, true, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.Two:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorTwo, true);
                    CommandFactory.Create(wiiKeySelectorTwo.CommandType, wiiKeySelectorTwo.KeyCode, true, this.ControllerChanger).Behavior();
                    break;
            }
        }

        public void ButtonUpHandler(ButtonUpEventArgs e) {
            switch (e.Button) {
                case WiimoteDevice.Controller.Buttons.Up:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorUp, false);
                    CommandFactory.Create(wiiKeySelectorUp.CommandType, wiiKeySelectorUp.KeyCode, false, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.Down:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorDown, false);
                    CommandFactory.Create(wiiKeySelectorDown.CommandType, wiiKeySelectorDown.KeyCode, false, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.Left:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorLeft, false);
                    CommandFactory.Create(wiiKeySelectorLeft.CommandType, wiiKeySelectorLeft.KeyCode, false, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.Right:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorRight, false);
                    CommandFactory.Create(wiiKeySelectorRight.CommandType, wiiKeySelectorRight.KeyCode, false, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.A:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorA, false);
                    CommandFactory.Create(wiiKeySelectorA.CommandType, wiiKeySelectorA.KeyCode, false, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.B:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorB, false);
                    CommandFactory.Create(wiiKeySelectorB.CommandType, wiiKeySelectorB.KeyCode, false, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.Plus:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorPlus, false);
                    CommandFactory.Create(wiiKeySelectorPlus.CommandType, wiiKeySelectorPlus.KeyCode, false, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.Home:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorHome, false);
                    CommandFactory.Create(wiiKeySelectorHome.CommandType, wiiKeySelectorHome.KeyCode, false, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.Minus:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorMinus, false);
                    CommandFactory.Create(wiiKeySelectorMinus.CommandType, wiiKeySelectorMinus.KeyCode, false, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.One:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorOne, false);
                    CommandFactory.Create(wiiKeySelectorOne.CommandType, wiiKeySelectorOne.KeyCode, false, this.ControllerChanger).Behavior();
                    break;
                case WiimoteDevice.Controller.Buttons.Two:
                    this.Invoke(new CheckDelegate(Check), wiiKeySelectorTwo, false);
                    CommandFactory.Create(wiiKeySelectorTwo.CommandType, wiiKeySelectorTwo.KeyCode, false, this.ControllerChanger).Behavior();
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                WiimoteSetting setting = Setting.Loader.Load();
                setting.Controller[this.No - 1] = ToControllerSetting(this.No);
                Setting.Saver.Save(setting);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Save Settings Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDefault_Click(object sender, EventArgs e) {
            SetDefault();
        }

        private void SetDefault() {
            Setting.ControllerSetting setting = Setting.ControllerSetting.Default1;
            switch (No) {
                case 1: setting = Setting.ControllerSetting.Default1; break;
                case 2: setting = Setting.ControllerSetting.Default1; break;
                case 3: setting = Setting.ControllerSetting.Default1; break;
                case 4: setting = Setting.ControllerSetting.Default1; break;
            }
   
            LoadSetting(setting);
        }


        public ControllerSetting ToControllerSetting(int settingNo) {
            ControllerSetting setting = new ControllerSetting();
            setting.No = settingNo;
            setting.KeyMaps = new KeyMap[11];
            setting.KeyMaps[0] = wiiKeySelectorUp.ToKeyMap();
            setting.KeyMaps[1] = wiiKeySelectorDown.ToKeyMap();
            setting.KeyMaps[2] = wiiKeySelectorLeft.ToKeyMap();
            setting.KeyMaps[3] = wiiKeySelectorRight.ToKeyMap();
            setting.KeyMaps[4] = wiiKeySelectorA.ToKeyMap();
            setting.KeyMaps[5] = wiiKeySelectorB.ToKeyMap();
            setting.KeyMaps[6] = wiiKeySelectorMinus.ToKeyMap();
            setting.KeyMaps[7] = wiiKeySelectorHome.ToKeyMap();
            setting.KeyMaps[8] = wiiKeySelectorPlus.ToKeyMap();
            setting.KeyMaps[9] = wiiKeySelectorOne.ToKeyMap();
            setting.KeyMaps[10] = wiiKeySelectorTwo.ToKeyMap();

            return setting;
        }


        public void LoadSetting(ControllerSetting setting) {
            wiiKeySelectorUp.LoadKeyMap(setting.KeyMaps[0]);
            wiiKeySelectorDown.LoadKeyMap(setting.KeyMaps[1]);
            wiiKeySelectorLeft.LoadKeyMap(setting.KeyMaps[2]);
            wiiKeySelectorRight.LoadKeyMap(setting.KeyMaps[3]);
            wiiKeySelectorA.LoadKeyMap(setting.KeyMaps[4]);
            wiiKeySelectorB.LoadKeyMap(setting.KeyMaps[5]);
            wiiKeySelectorMinus.LoadKeyMap(setting.KeyMaps[6]);
            wiiKeySelectorHome.LoadKeyMap(setting.KeyMaps[7]);
            wiiKeySelectorPlus.LoadKeyMap(setting.KeyMaps[8]);
            wiiKeySelectorOne.LoadKeyMap(setting.KeyMaps[9]);
            wiiKeySelectorTwo.LoadKeyMap(setting.KeyMaps[10]);
        }

        
    }
}

