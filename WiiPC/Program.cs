using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace WiiPC
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool bNew = false;
            Mutex mutex = new Mutex(true, "WiiPC", out bNew);

            if(bNew == false) {
                MessageBox.Show("WiiPC already running", "WiiPC");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
            mutex.ReleaseMutex();
        }
    }
}
