using System;
using System.Collections.Generic;
using System.Text;
using WiimoteLib;
using System.Threading;

namespace WiimoteDevice
{
    public class Controller : IDisposable
    {
        public enum Buttons { Up = 0, Down = 1, Left = 2, Right = 3, A = 4, B = 5, Minus = 6, Home = 7, Plus = 8, One = 9, Two = 10 };

        public float Battery { get { return this.wiimote.WiimoteState.Battery; } }
        public int KeyboardDelay { get; set; }
        public int KeyboardSpeed { get; set; }

        public event EventHandler<ButtonPressEventArgs> ButtonPress;
        public event EventHandler<ButtonUpEventArgs> ButtonUp;

        private Wiimote wiimote;
        private WiimoteState PreWiimoteState = new WiimoteState();
        private Object EventLockObj = new object();
        private Object GeneratorLockObj = new object();

        private Thread EventGeneratorThread;
        private bool IsGeneratorBusy = false;



        public Controller() {
            wiimote = new Wiimote();
            wiimote.WiimoteChanged += new EventHandler<WiimoteChangedEventArgs>(PreWiimoteChnaged);
            this.KeyboardDelay = System.Windows.Forms.SystemInformation.KeyboardDelay * 1000;
            this.KeyboardSpeed = System.Windows.Forms.SystemInformation.KeyboardSpeed;
        }

        private void EventGenerate() {
            // wait repeat delay
            try {
                Thread.Sleep(this.KeyboardDelay);
            
                IsGeneratorBusy = true;
                while (IsGeneratorBusy) {
                    Thread.Sleep(KeyboardSpeed);
                    this.wiimote_WiimoteChanged(this, new WiimoteChangedEventArgs(this.PreWiimoteState));
                }
            } catch (ThreadInterruptedException) { }
        }

        private void StartGeneration() {
            lock (GeneratorLockObj) {
                if (EventGeneratorThread == null) {
                    StopGeneration();

                    EventGeneratorThread = new Thread(EventGenerate);
                    EventGeneratorThread.IsBackground = true;
                    this.EventGeneratorThread.Start();
                }
            }
        }

        private void StopGeneration() {
            lock (GeneratorLockObj) {
                if (EventGeneratorThread != null) {
                    IsGeneratorBusy = false;
                    this.EventGeneratorThread.Interrupt();
                    this.EventGeneratorThread = null;
                }
            }
        }


        public void Connect() {
            try {
                wiimote.Connect();
                InitPreButtonsState(false);
            } catch (Exception e) {
                throw e;
            }
        }

        private void InitPreButtonsState(bool released) {
            this.PreWiimoteState.ButtonState.A = released;
            this.PreWiimoteState.ButtonState.B = released;
            this.PreWiimoteState.ButtonState.Down = released;
            this.PreWiimoteState.ButtonState.Home = released;
            this.PreWiimoteState.ButtonState.Left = released;
            this.PreWiimoteState.ButtonState.Minus = released;
            this.PreWiimoteState.ButtonState.One = released;
            this.PreWiimoteState.ButtonState.Plus = released;
            this.PreWiimoteState.ButtonState.Right = released;
            this.PreWiimoteState.ButtonState.Two = released;
            this.PreWiimoteState.ButtonState.Up = released;
        }


        public void Disconnect() {
            SetLED(false, false, false, false);
            StopGeneration();
            wiimote.Disconnect();
        }

        public void SetLED(bool led1, bool led2, bool led3, bool led4) {
            wiimote.SetLEDs(led1, led2, led3, led4);
        }

        public void SetRumble(int duration) {
            Thread td = new Thread(Rumble) { IsBackground = true };
            td.Start(duration);
        }

        private void Rumble(object duration) {
            try {
                wiimote.SetRumble(true);
                try { Thread.Sleep((int)duration); } catch (Exception) { }
            } catch (Exception) {
            } finally {
                wiimote.SetRumble(false);
            }
        }

        void PreWiimoteChnaged(object sender, WiimoteChangedEventArgs e) {
            // keypressed
            ButtonState buttons = e.WiimoteState.ButtonState;
            bool anyButtonPressed = (buttons.A || buttons.B || buttons.Down || buttons.Home || buttons.Left || buttons.Minus || buttons.One || buttons.Plus || buttons.Right || buttons.Two || buttons.Up);
            if (anyButtonPressed == false) {
                StopGeneration();
            }
            wiimote_WiimoteChanged(sender, e);
            if (anyButtonPressed == true) {
                StartGeneration();
            }
        }

        void wiimote_WiimoteChanged(object sender, WiimoteChangedEventArgs e) {
            ButtonState buttons = e.WiimoteState.ButtonState;

            lock (this.EventLockObj) {

                // Key Up
                if (buttons.Up != this.PreWiimoteState.ButtonState.Up) {
                    this.PreWiimoteState.ButtonState.Up = buttons.Up;
                    if (buttons.Up == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Up)); } else { OnKeyUp(new ButtonUpEventArgs(Buttons.Up)); }
                } else {
                    if (buttons.Up == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Up)); }
                }

                // Key Down
                if (buttons.Down != this.PreWiimoteState.ButtonState.Down) {
                    this.PreWiimoteState.ButtonState.Down = buttons.Down;
                    if (buttons.Down == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Down)); } else { OnKeyUp(new ButtonUpEventArgs(Buttons.Down)); }
                } else {
                    if (buttons.Down == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Down)); }
                }

                // Key Left
                if (buttons.Left != this.PreWiimoteState.ButtonState.Left) {
                    this.PreWiimoteState.ButtonState.Left = buttons.Left;
                    if (buttons.Left == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Left)); } else { OnKeyUp(new ButtonUpEventArgs(Buttons.Left)); }
                } else {
                    if (buttons.Left == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Left)); }
                }

                // Key Right
                if (buttons.Right != this.PreWiimoteState.ButtonState.Right) {
                    this.PreWiimoteState.ButtonState.Right = buttons.Right;
                    if (buttons.Right == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Right)); } else { OnKeyUp(new ButtonUpEventArgs(Buttons.Right)); }
                } else {
                    if (buttons.Right == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Right)); }
                }


                // Key A
                if (buttons.A != this.PreWiimoteState.ButtonState.A) {
                    this.PreWiimoteState.ButtonState.A = buttons.A;
                    if (buttons.A == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.A)); } else { OnKeyUp(new ButtonUpEventArgs(Buttons.A)); }
                } else {
                    if (buttons.A == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.A)); }
                }

                // Key B
                if (buttons.B != this.PreWiimoteState.ButtonState.B) {
                    this.PreWiimoteState.ButtonState.B = buttons.B;
                    if (buttons.B == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.B)); } else { OnKeyUp(new ButtonUpEventArgs(Buttons.B)); }
                } else {
                    if (buttons.B == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.B)); }
                }

                // Key Plus
                if (buttons.Plus != this.PreWiimoteState.ButtonState.Plus) {
                    this.PreWiimoteState.ButtonState.Plus = buttons.Plus;
                    if (buttons.Plus == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Plus)); } else { OnKeyUp(new ButtonUpEventArgs(Buttons.Plus)); }
                } else {
                    if (buttons.Plus == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Plus)); }
                }

                // Key Home
                if (buttons.Home != this.PreWiimoteState.ButtonState.Home) {
                    this.PreWiimoteState.ButtonState.Home = buttons.Home;
                    if (buttons.Home == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Home)); } else { OnKeyUp(new ButtonUpEventArgs(Buttons.Home)); }
                } else {
                    if (buttons.Home == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Home)); }
                }
                // Key Minus
                if (buttons.Minus != this.PreWiimoteState.ButtonState.Minus) {
                    this.PreWiimoteState.ButtonState.Minus = buttons.Minus;
                    if (buttons.Minus == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Minus)); } else { OnKeyUp(new ButtonUpEventArgs(Buttons.Minus)); }
                } else {
                    if (buttons.Minus == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Minus)); }
                }

                // Key One
                if (buttons.One != this.PreWiimoteState.ButtonState.One) {
                    this.PreWiimoteState.ButtonState.One = buttons.One;
                    if (buttons.One == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.One)); } else { OnKeyUp(new ButtonUpEventArgs(Buttons.One)); }
                } else {
                    if (buttons.One == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.One)); }
                }
                // Key Two
                if (buttons.Two != this.PreWiimoteState.ButtonState.Two) {
                    this.PreWiimoteState.ButtonState.Two = buttons.Two;
                    if (buttons.Two == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Two)); } else { OnKeyUp(new ButtonUpEventArgs(Buttons.Two)); }
                } else {
                    if (buttons.Two == true) { OnKeyPress(new ButtonPressEventArgs(Buttons.Two)); }
                }
            }
        }
            

        protected virtual void OnKeyPress(ButtonPressEventArgs e) {
            if(this.ButtonPress != null) {
                this.ButtonPress(this, e);
            }
        }

        protected virtual void OnKeyUp(ButtonUpEventArgs e) {
            if(this.ButtonUp != null) {
                this.ButtonUp(this, e);
            }
        }



        public void Dispose() {
            this.Disconnect();
            this.wiimote.Dispose();
            this.wiimote.WiimoteChanged -= new EventHandler<WiimoteChangedEventArgs>(PreWiimoteChnaged);
        }

        public bool isConnected()
        {
            return this.wiimote.isConnected();
        }

    }
}
