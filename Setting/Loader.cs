using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Setting
{
    public class Loader
    {
        public static WiimoteSetting Load() {
            String path = Wiimote.SaveFileName; 

            if (File.Exists(path) == false) {
                return WiimoteSetting.Default;
            }

            WiimoteSetting setting;
            try {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream f = new FileStream(path, FileMode.Open)) {
                    setting = (WiimoteSetting)(binaryFormatter.Deserialize(f));
                    f.Close();
                }
            } catch (Exception) { return WiimoteSetting.Default; }

            return setting;
        }
    }
}
