using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WiiPC.Popup
{
    public partial class PopupBox : Form
    {
        public String Message { set { this.lblMessage.Text = value; } }

        public PopupBox() {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e) {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(width - this.Width - 10, height - this.Height - 10);
            base.OnLoad(e);
        }
    }
}
