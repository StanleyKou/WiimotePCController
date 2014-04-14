using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WiiPC.Component
{
    class KeySelectorBox : ComboBox
    {
        public int KeyCode { 
            get { return (int)Enum.Parse(typeof(Keys), this.SelectedItem.ToString()); }
        }

        public KeySelectorBox()
            : base()
        {
            this.Items.AddRange(Enum.GetNames(typeof(Keys)));
            if (this.Items.Count > 0) {
                this.SelectedIndex = 0;
            }
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
