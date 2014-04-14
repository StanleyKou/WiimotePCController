using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace WiiPC.Command
{
    class MouseInputCommand : ICommand
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetCursorPos(out POINT lpPoint);

        public enum Actions { None, MoveUp, MoveDown, MoveLeft, MoveRight, LeftClick, RightClick, MiddleClick, WheelDown, WheelUp}
        public static int Distance = 10;

        private const uint WM_LBUTTONDOWN = 0x00000002;
        private const uint WM_LBUTTONUP = 0x00000004;
        //private const uint WM_MOUSEMOVE = 0x0200;
        private const uint WM_MOUSEWHEEL = 0x00000800;
        private const uint WM_MIDDLEDOWN = 0x00000020;
        private const uint WM_MIDDLEUP = 0x00000040;
        private const uint WM_RBUTTONDOWN = 0x00000008;
        private const uint WM_RBUTTONUP = 0x00000010;

        public int WheelDelta { get; set; }


        public struct POINT
        {
            public int X;
            public int Y;
        }

        private int KeyCode = 0;
        private bool IsPressed = false;

        public MouseInputCommand(int keyCode, bool pressed)
        {
            this.KeyCode = keyCode;
            this.IsPressed = pressed;
            this.WheelDelta = System.Windows.Forms.SystemInformation.MouseWheelScrollDelta;
        }

        public void Behavior() {
            try {
                Actions action = (Actions)this.KeyCode;

                switch (action) {
                    case Actions.MoveUp:
                    case Actions.MoveDown:
                    case Actions.MoveLeft:
                    case Actions.MoveRight: {
                            if (this.IsPressed == true) {
                                // Move
                                POINT mousePos;
                                if (GetCursorPos(out mousePos) == true) {
                                    switch (action) {
                                        case Actions.MoveUp: mousePos.Y -= Distance; break;
                                        case Actions.MoveDown: mousePos.Y += Distance; break;
                                        case Actions.MoveLeft: mousePos.X -= Distance; break;
                                        case Actions.MoveRight: mousePos.X += Distance; break;
                                    }
                                    SetCursorPos(mousePos.X, mousePos.Y);
                                }
                            }
                        }
                        break;
                    case Actions.LeftClick:
                        if (this.IsPressed == true) {
                            mouse_event(WM_LBUTTONDOWN, 0, 0, 0, 0);
                        } else {
                            mouse_event(WM_LBUTTONUP, 0, 0, 0, 0);
                        }
                        break;
                    case Actions.RightClick:
                        if (this.IsPressed == true) {
                            mouse_event(WM_RBUTTONDOWN, 0, 0, 0, 0);
                        } else {
                            mouse_event(WM_RBUTTONUP, 0, 0, 0, 0);
                        }
                        break;
                    case Actions.MiddleClick:
                        if (this.IsPressed == true) {
                            mouse_event(WM_MIDDLEDOWN, 0, 0, 0, 0);
                        } else {
                            mouse_event(WM_MIDDLEUP, 0, 0, 0, 0);
                        }
                        break;
                    case Actions.WheelDown:
                        if (this.IsPressed == true) {
                            mouse_event(WM_MOUSEWHEEL, 0, 0, -WheelDelta, 0);
                        }
                        break;
                    case Actions.WheelUp:
                        if (this.IsPressed == true) {
                            mouse_event(WM_MOUSEWHEEL, 0, 0, WheelDelta, 0);
                        }
                        break;
                }
            } catch (Exception) { }
        }
    }
}
