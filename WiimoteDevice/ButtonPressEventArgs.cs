using System;
using System.Collections.Generic;
using System.Text;

namespace WiimoteDevice
{
    public class ButtonPressEventArgs : EventArgs
    {
        public Controller.Buttons Button { get; set; }

        public ButtonPressEventArgs(Controller.Buttons button) {
            this.Button = button;
        }
    }
}
