using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WiiPC.Command;

namespace WiiPC.Component
{
    class SystemFuncSelectorBox : ComboBox
    {
        public int KeyCode { get { return (int)Enum.Parse(typeof(SystemFunctionCommand.Actions), this.SelectedItem.ToString()); } }

        public SystemFuncSelectorBox()
            : base()
        {
            this.Items.AddRange(Enum.GetNames(typeof(SystemFunctionCommand.Actions)));
            if (this.Items.Count > 0) {
                this.SelectedIndex = 0;
            }
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
