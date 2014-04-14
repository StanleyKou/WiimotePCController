using System;
using System.Collections.Generic;
using System.Text;
using WiiPC;

namespace WiiPC.Command
{
    public class CommandFactory
    {
        public enum Types { None = 0, KeyInput = 1, MouseMove = 2, SystemFunction = 3 }

        public static ICommand Create(Types type, int keyCode, bool isPressed, IControllerChanger controllerChanger)
        {
            switch (type)
            {
                case Types.KeyInput:
                    return new KeyInputCommand(keyCode, isPressed);
                case Types.MouseMove:
                    return new MouseInputCommand(keyCode, isPressed);
                case Types.SystemFunction:
                    return new SystemFunctionCommand(keyCode, isPressed, controllerChanger);
                default:
                    return new DefaultCommand();
            }
        }
    }
}
