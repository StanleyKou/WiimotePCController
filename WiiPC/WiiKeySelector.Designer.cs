namespace WiiPC
{
    partial class WiiKeySelector
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.WiimoteKey = new System.Windows.Forms.CheckBox();
            this.SystemKey = new WiiPC.Component.SystemFuncSelectorBox();
            this.MouseKey = new WiiPC.Component.MouseSelectorBox();
            this.WindowsKey = new WiiPC.Component.KeySelectorBox();
            this.SuspendLayout();
            // 
            // WiimoteKey
            // 
            this.WiimoteKey.AutoSize = true;
            this.WiimoteKey.Location = new System.Drawing.Point(9, 3);
            this.WiimoteKey.Name = "WiimoteKey";
            this.WiimoteKey.Size = new System.Drawing.Size(80, 16);
            this.WiimoteKey.TabIndex = 1;
            this.WiimoteKey.Text = "KeyName";
            this.WiimoteKey.UseVisualStyleBackColor = true;
            // 
            // SystemKey
            // 
            this.SystemKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SystemKey.FormattingEnabled = true;
            this.SystemKey.Location = new System.Drawing.Point(356, 1);
            this.SystemKey.Name = "SystemKey";
            this.SystemKey.Size = new System.Drawing.Size(99, 20);
            this.SystemKey.TabIndex = 3;
            // 
            // MouseKey
            // 
            this.MouseKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MouseKey.FormattingEnabled = true;
            this.MouseKey.Location = new System.Drawing.Point(251, 1);
            this.MouseKey.Name = "MouseKey";
            this.MouseKey.Size = new System.Drawing.Size(99, 20);
            this.MouseKey.TabIndex = 2;
            // 
            // WindowsKey
            // 
            this.WindowsKey.BackColor = System.Drawing.SystemColors.Window;
            this.WindowsKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WindowsKey.Location = new System.Drawing.Point(95, 1);
            this.WindowsKey.Name = "WindowsKey";
            this.WindowsKey.Size = new System.Drawing.Size(150, 20);
            this.WindowsKey.TabIndex = 0;
            // 
            // WiiKeySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SystemKey);
            this.Controls.Add(this.MouseKey);
            this.Controls.Add(this.WiimoteKey);
            this.Controls.Add(this.WindowsKey);
            this.Name = "WiiKeySelector";
            this.Size = new System.Drawing.Size(458, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Component.KeySelectorBox WindowsKey;
        private System.Windows.Forms.CheckBox WiimoteKey;
        private Component.MouseSelectorBox MouseKey;
        private Component.SystemFuncSelectorBox SystemKey;

    }
}
