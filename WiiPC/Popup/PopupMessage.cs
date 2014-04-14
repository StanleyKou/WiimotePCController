using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WiiPC.Popup
{
    class PopupMessage
    {
        private PopupBox popup = new PopupBox();
        private Thread PopupThread;
        private delegate void VisibleSetDelegate(bool visible);
        public int Time { get; set; }

        public PopupMessage() {
            this.Time = 1500;
        }


        //====================================
        // Popup 을 보여줍니다.
        //====================================
        public void Show(String message) {
            popup.Message = message.ToString();
            popup.Show();

            if (PopupThread != null) {
                PopupThread.Interrupt();
            }
            PopupThread = new Thread(LazyClose) { IsBackground = true };
            PopupThread.Start();
        }


        //====================================
        // 특정 시간이 지나면 Popup 을 숨깁니다.
        //====================================
        private void LazyClose() {
            try {
                Thread.Sleep(Time);
                popup.Invoke(new VisibleSetDelegate(SetVisible), false);
            } catch (Exception) { }
        }


        // delegate
        private void SetVisible(bool show) {
            this.popup.Visible = show;
        }
    }
}
