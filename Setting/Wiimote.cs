using System;
using System.Collections.Generic;
using System.Text;

namespace Setting
{
    class Wiimote
    {
        public static String SaveFileName { get { return "config.inf"; } }
    }

    [Serializable]
    public struct KeyMap
    {
        public int CommandType;
        public int Index;

        public KeyMap(int type, int index) {
            this.CommandType = type;
            this.Index = index;
        }
    }

    [Serializable]
    public struct ControllerSetting
    {
        public int No;
        public KeyMap[] KeyMaps;

        public static ControllerSetting Default1 {
            get {
                ControllerSetting setting = new ControllerSetting();
                setting.No = 0;
                setting.KeyMaps = new KeyMap[11];
                setting.KeyMaps[0] = new KeyMap(2, 1);
                setting.KeyMaps[1] = new KeyMap(2, 2);
                setting.KeyMaps[2] = new KeyMap(2, 3);
                setting.KeyMaps[3] = new KeyMap(2, 4);
                setting.KeyMaps[4] = new KeyMap(2, 5);
                setting.KeyMaps[5] = new KeyMap(2, 6);
                setting.KeyMaps[6] = new KeyMap(1, 139);
                setting.KeyMaps[7] = new KeyMap(1, 145);
                setting.KeyMaps[8] = new KeyMap(1, 140);
                setting.KeyMaps[9] = new KeyMap(3, 6);
                setting.KeyMaps[10] = new KeyMap(3, 4);
                return setting;
            }
        }

        public static ControllerSetting Default2 {
            get {
                ControllerSetting setting = new ControllerSetting();
                setting.No = 0;
                setting.KeyMaps = new KeyMap[11];
                setting.KeyMaps[0] = new KeyMap(1, 40);
                setting.KeyMaps[1] = new KeyMap(1, 42);
                setting.KeyMaps[2] = new KeyMap(1, 39);
                setting.KeyMaps[3] = new KeyMap(1, 41);
                setting.KeyMaps[4] = new KeyMap(1, 11);
                setting.KeyMaps[5] = new KeyMap(1, 32);
                setting.KeyMaps[6] = new KeyMap(1, 147);
                setting.KeyMaps[7] = new KeyMap(1, 146);
                setting.KeyMaps[8] = new KeyMap(1, 148);
                setting.KeyMaps[9] = new KeyMap(3, 3);
                setting.KeyMaps[10] = new KeyMap(3, 5);
                return setting;
            }
        }

        public static ControllerSetting Default3 {
            get {
                ControllerSetting setting = new ControllerSetting();
                setting.No = 0;
                setting.KeyMaps = new KeyMap[11];
                setting.KeyMaps[0] = new KeyMap(2, 1);
                setting.KeyMaps[1] = new KeyMap(2, 2);
                setting.KeyMaps[2] = new KeyMap(2, 3);
                setting.KeyMaps[3] = new KeyMap(2, 4);
                setting.KeyMaps[4] = new KeyMap(2, 5);
                setting.KeyMaps[5] = new KeyMap(2, 6);
                setting.KeyMaps[6] = new KeyMap(1, 139);
                setting.KeyMaps[7] = new KeyMap(1, 145);
                setting.KeyMaps[8] = new KeyMap(1, 140);
                setting.KeyMaps[9] = new KeyMap(3, 4);
                setting.KeyMaps[10] = new KeyMap(3, 6);
                return setting;
            }
        }

        public static ControllerSetting Default4 {
            get {
                ControllerSetting setting = new ControllerSetting();
                setting.No = 0;
                setting.KeyMaps = new KeyMap[11];
                setting.KeyMaps[0] = new KeyMap(1, 40);
                setting.KeyMaps[1] = new KeyMap(1, 42);
                setting.KeyMaps[2] = new KeyMap(1, 39);
                setting.KeyMaps[3] = new KeyMap(1, 41);
                setting.KeyMaps[4] = new KeyMap(1, 11);
                setting.KeyMaps[5] = new KeyMap(1, 32);
                setting.KeyMaps[6] = new KeyMap(1, 147);
                setting.KeyMaps[7] = new KeyMap(1, 146);
                setting.KeyMaps[8] = new KeyMap(1, 148);
                setting.KeyMaps[9] = new KeyMap(3, 5);
                setting.KeyMaps[10] = new KeyMap(3, 3);
                return setting;
            }
        }
    }

    [Serializable]
    public struct WiimoteSetting
    {
        public bool DisplaySettingChanging;
        public bool DisplayLED;

        public ControllerSetting[] Controller;

        public static WiimoteSetting Default {
            get {
                WiimoteSetting setting = new WiimoteSetting();
                setting.DisplayLED = true;
                setting.DisplaySettingChanging = true;
                setting.Controller = new ControllerSetting[4];
                setting.Controller[0] = ControllerSetting.Default1;
                setting.Controller[1] = ControllerSetting.Default2;
                setting.Controller[2] = ControllerSetting.Default3;
                setting.Controller[3] = ControllerSetting.Default4;

                return setting;
            }
        }

        public WiimoteSetting(bool displaySettingChanging, bool displayLED, ControllerSetting setting1, ControllerSetting setting2, ControllerSetting setting3, ControllerSetting setting4) {
            this.DisplaySettingChanging = displaySettingChanging;
            this.DisplayLED = displayLED;
            this.Controller = new ControllerSetting[4];
            this.Controller[0] = setting1;
            this.Controller[1] = setting2;
            this.Controller[2] = setting3;
            this.Controller[3] = setting4;
        }
    }
}
