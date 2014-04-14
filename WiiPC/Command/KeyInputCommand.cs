using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace WiiPC.Command
{
    class KeyInputCommand : ICommand
    {
        [DllImport("user32.dll")]
        public static extern uint keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        //[DllImport("user32.dll")]
        //private static extern int MapVirtualKey(int wCode, int wMapType);

        private int KeyCode = 0;
        private bool IsPressed = false;

        public KeyInputCommand(int keyCode, bool pressed)
        {
            this.KeyCode = keyCode;
            this.IsPressed = pressed;
        }

        public void Behavior()
        {
            try {
                if (this.IsPressed == true) {
                    keybd_event((byte)KeyCode, 0, 0, 0);    // key down
                } else {
                    keybd_event((byte)KeyCode, 0, 0x02, 0); // key up
                }
            } catch (Exception) { }
        }
    }
}
