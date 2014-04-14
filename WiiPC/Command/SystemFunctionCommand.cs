using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WiiPC.Command
{
    class SystemFunctionCommand : ICommand
    {
        public enum Actions { None, SystemOff, Alt_F4, ToSetting_1, ToSetting_2, ToSetting_3, ToSetting_4, VirtualKeyboard }

        private int KeyCode = 0;
        private bool IsPressed = false;
        private IControllerChanger Changer;

        public SystemFunctionCommand(int keyCode, bool isPressed, IControllerChanger controllerChanger)
        {
            this.KeyCode = keyCode;
            this.IsPressed = isPressed;
            this.Changer = controllerChanger;
        }

        public void Behavior()
        {
            try {
                if (this.IsPressed == false) {
                    switch ((Actions)this.KeyCode) {
                        case Actions.SystemOff:
                            System.Diagnostics.Process.Start("shutdown", "/s /f /t 10");
                            break;
                        case Actions.Alt_F4:
                            KeyInputCommand.keybd_event(18, 0, 0, 0);
                            KeyInputCommand.keybd_event((byte)Keys.F4, 0, 0, 0);
                            KeyInputCommand.keybd_event((byte)Keys.F4, 0, 0x02, 0);
                            KeyInputCommand.keybd_event(18, 0, 0x02, 0);
                            break;
                        case Actions.ToSetting_1:
                            this.Changer.ChangeController(1);
                            break;
                        case Actions.ToSetting_2:
                            this.Changer.ChangeController(2);
                            break;
                        case Actions.ToSetting_3:
                            this.Changer.ChangeController(3);
                            break;
                        case Actions.ToSetting_4:
                            this.Changer.ChangeController(4);
                            break;
                        case Actions.VirtualKeyboard:
                            StartOSK();
                            //ProcessStartInfo p = new ProcessStartInfo(((Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\osk.exe")));
                            //Process.Start(p);
                            break;
                    }
                }
            } catch (Exception) { }
        }

        private static void StartOSK() {
            string windir = Environment.GetEnvironmentVariable("WINDIR");
            string osk = null;

            if (osk == null) {
                osk = Path.Combine(Path.Combine(windir, "sysnative"), "osk.exe");
                if (!File.Exists(osk)) {
                    osk = null;
                }
            }

            if (osk == null) {
                osk = Path.Combine(Path.Combine(windir, "system32"), "osk.exe");
                if (!File.Exists(osk)) {
                    osk = null;
                }
            }

            if (osk == null) {
                osk = "osk.exe";
            }

            Process.Start(osk);
        }
    }
}
