using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Setting
{
    public class Saver
    {
        public static bool Save(WiimoteSetting setting) {
            String path = Wiimote.SaveFileName; 
            bool result = false;
            FileStream f = null;
            try {
                BinaryFormatter x = new BinaryFormatter();
                f = new FileStream(path, FileMode.Create);
                x.Serialize(f, setting);
                result = true;
            } catch (Exception) {
            } finally {
                if (f != null) {
                    f.Close();
                    f.Dispose();
                }
            }

            return result;
        }
    }
}
