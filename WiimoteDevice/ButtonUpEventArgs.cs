using System;
using System.Collections.Generic;
using System.Text;

namespace WiimoteDevice
{
    public class ButtonUpEventArgs : EventArgs
    {
        public Controller.Buttons Button { get; set; }

        public ButtonUpEventArgs(Controller.Buttons button) {
            this.Button = button;
        }
    }
}
