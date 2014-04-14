using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace WiiPC.Command
{
    class MouseMoveCommand : ICommand
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetCursorPos(out POINT lpPoint);

        public enum Moves { None, MoveUp, MoveDown, MoveLeft, MoveRight }
        public static int Distance = 10;

        public struct POINT
        {
            public int X;
            public int Y;
        }

        private int KeyCode = 0;
        private bool IsPressed = false;

        public MouseMoveCommand(int keyCode, bool pressed)
        {
            this.KeyCode = keyCode;
            this.IsPressed = pressed;
        }

        public void Behavior()
        {
            if (this.IsPressed == true) {
                Moves action = (Moves)this.KeyCode;
                POINT mousePos;
                if (GetCursorPos(out mousePos) == true) {
                    switch (action) {
                        case Moves.MoveUp: mousePos.Y -= Distance; break;
                        case Moves.MoveDown: mousePos.Y += Distance; break;
                        case Moves.MoveLeft: mousePos.X -= Distance; break;
                        case Moves.MoveRight: mousePos.X += Distance; break;
                    }
                    SetCursorPos(mousePos.X, mousePos.Y);
                }
            }
        }
    }
}
