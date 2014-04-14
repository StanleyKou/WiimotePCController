using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WiiPC.Command;

namespace WiiPC.Component
{
    class MouseSelectorBox : ComboBox
    {
        public int KeyCode { get { return (int)Enum.Parse(typeof(MouseInputCommand.Actions), this.SelectedItem.ToString()); } }

        public MouseSelectorBox()
            : base()
        {
            this.Items.AddRange(Enum.GetNames(typeof(MouseInputCommand.Actions)));
            if (this.Items.Count > 0) {
                this.SelectedIndex = 0;
            }
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
