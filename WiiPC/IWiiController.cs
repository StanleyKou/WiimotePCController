using System;
using System.Collections.Generic;
using System.Text;
using WiimoteDevice;

namespace WiiPC
{
    interface IWiiController
    {
        void ButtonPressHandler(ButtonPressEventArgs e);
        void ButtonUpHandler(ButtonUpEventArgs e);
    }
}
