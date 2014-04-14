namespace WiiPC
{
    partial class WiiController
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wiiKeySelectorTwo = new WiiPC.WiiKeySelector();
            this.wiiKeySelectorOne = new WiiPC.WiiKeySelector();
            this.wiiKeySelectorHome = new WiiPC.WiiKeySelector();
            this.wiiKeySelectorPlus = new WiiPC.WiiKeySelector();
            this.wiiKeySelectorMinus = new WiiPC.WiiKeySelector();
            this.wiiKeySelectorB = new WiiPC.WiiKeySelector();
            this.wiiKeySelectorA = new WiiPC.WiiKeySelector();
            this.wiiKeySelectorRight = new WiiPC.WiiKeySelector();
            this.wiiKeySelectorLeft = new WiiPC.WiiKeySelector();
            this.wiiKeySelectorDown = new WiiPC.WiiKeySelector();
            this.wiiKeySelectorUp = new WiiPC.WiiKeySelector();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(272, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(375, 386);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(97, 23);
            this.btnDefault.TabIndex = 13;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mouse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Keyboard";
            // 
            // wiiKeySelectorTwo
            // 
            this.wiiKeySelectorTwo.Location = new System.Drawing.Point(14, 340);
            this.wiiKeySelectorTwo.MouseKeyText = "None";
            this.wiiKeySelectorTwo.Name = "wiiKeySelectorTwo";
            this.wiiKeySelectorTwo.Size = new System.Drawing.Size(458, 24);
            this.wiiKeySelectorTwo.SystemKeyText = "None";
            this.wiiKeySelectorTwo.TabIndex = 10;
            this.wiiKeySelectorTwo.WiimoteKeyText = "2";
            this.wiiKeySelectorTwo.WindowsKeyText = "None";
            // 
            // wiiKeySelectorOne
            // 
            this.wiiKeySelectorOne.Location = new System.Drawing.Point(14, 310);
            this.wiiKeySelectorOne.MouseKeyText = "None";
            this.wiiKeySelectorOne.Name = "wiiKeySelectorOne";
            this.wiiKeySelectorOne.Size = new System.Drawing.Size(458, 24);
            this.wiiKeySelectorOne.SystemKeyText = "None";
            this.wiiKeySelectorOne.TabIndex = 9;
            this.wiiKeySelectorOne.WiimoteKeyText = "1";
            this.wiiKeySelectorOne.WindowsKeyText = "None";
            // 
            // wiiKeySelectorHome
            // 
            this.wiiKeySelectorHome.Location = new System.Drawing.Point(14, 280);
            this.wiiKeySelectorHome.MouseKeyText = "None";
            this.wiiKeySelectorHome.Name = "wiiKeySelectorHome";
            this.wiiKeySelectorHome.Size = new System.Drawing.Size(458, 24);
            this.wiiKeySelectorHome.SystemKeyText = "None";
            this.wiiKeySelectorHome.TabIndex = 8;
            this.wiiKeySelectorHome.WiimoteKeyText = "Home";
            this.wiiKeySelectorHome.WindowsKeyText = "None";
            // 
            // wiiKeySelectorPlus
            // 
            this.wiiKeySelectorPlus.Location = new System.Drawing.Point(14, 250);
            this.wiiKeySelectorPlus.MouseKeyText = "None";
            this.wiiKeySelectorPlus.Name = "wiiKeySelectorPlus";
            this.wiiKeySelectorPlus.Size = new System.Drawing.Size(458, 24);
            this.wiiKeySelectorPlus.SystemKeyText = "None";
            this.wiiKeySelectorPlus.TabIndex = 7;
            this.wiiKeySelectorPlus.WiimoteKeyText = "+";
            this.wiiKeySelectorPlus.WindowsKeyText = "None";
            // 
            // wiiKeySelectorMinus
            // 
            this.wiiKeySelectorMinus.Location = new System.Drawing.Point(14, 220);
            this.wiiKeySelectorMinus.MouseKeyText = "None";
            this.wiiKeySelectorMinus.Name = "wiiKeySelectorMinus";
            this.wiiKeySelectorMinus.Size = new System.Drawing.Size(458, 24);
            this.wiiKeySelectorMinus.SystemKeyText = "None";
            this.wiiKeySelectorMinus.TabIndex = 6;
            this.wiiKeySelectorMinus.WiimoteKeyText = "-";
            this.wiiKeySelectorMinus.WindowsKeyText = "None";
            // 
            // wiiKeySelectorB
            // 
            this.wiiKeySelectorB.Location = new System.Drawing.Point(14, 190);
            this.wiiKeySelectorB.MouseKeyText = "None";
            this.wiiKeySelectorB.Name = "wiiKeySelectorB";
            this.wiiKeySelectorB.Size = new System.Drawing.Size(458, 24);
            this.wiiKeySelectorB.SystemKeyText = "None";
            this.wiiKeySelectorB.TabIndex = 5;
            this.wiiKeySelectorB.WiimoteKeyText = "B";
            this.wiiKeySelectorB.WindowsKeyText = "None";
            // 
            // wiiKeySelectorA
            // 
            this.wiiKeySelectorA.Location = new System.Drawing.Point(14, 160);
            this.wiiKeySelectorA.MouseKeyText = "None";
            this.wiiKeySelectorA.Name = "wiiKeySelectorA";
            this.wiiKeySelectorA.Size = new System.Drawing.Size(458, 24);
            this.wiiKeySelectorA.SystemKeyText = "None";
            this.wiiKeySelectorA.TabIndex = 4;
            this.wiiKeySelectorA.WiimoteKeyText = "A";
            this.wiiKeySelectorA.WindowsKeyText = "None";
            // 
            // wiiKeySelectorRight
            // 
            this.wiiKeySelectorRight.Location = new System.Drawing.Point(14, 130);
            this.wiiKeySelectorRight.MouseKeyText = "None";
            this.wiiKeySelectorRight.Name = "wiiKeySelectorRight";
            this.wiiKeySelectorRight.Size = new System.Drawing.Size(458, 24);
            this.wiiKeySelectorRight.SystemKeyText = "None";
            this.wiiKeySelectorRight.TabIndex = 3;
            this.wiiKeySelectorRight.WiimoteKeyText = "Right";
            this.wiiKeySelectorRight.WindowsKeyText = "None";
            // 
            // wiiKeySelectorLeft
            // 
            this.wiiKeySelectorLeft.Location = new System.Drawing.Point(14, 100);
            this.wiiKeySelectorLeft.MouseKeyText = "None";
            this.wiiKeySelectorLeft.Name = "wiiKeySelectorLeft";
            this.wiiKeySelectorLeft.Size = new System.Drawing.Size(458, 24);
            this.wiiKeySelectorLeft.SystemKeyText = "None";
            this.wiiKeySelectorLeft.TabIndex = 2;
            this.wiiKeySelectorLeft.WiimoteKeyText = "Left";
            this.wiiKeySelectorLeft.WindowsKeyText = "None";
            // 
            // wiiKeySelectorDown
            // 
            this.wiiKeySelectorDown.Location = new System.Drawing.Point(14, 70);
            this.wiiKeySelectorDown.MouseKeyText = "None";
            this.wiiKeySelectorDown.Name = "wiiKeySelectorDown";
            this.wiiKeySelectorDown.Size = new System.Drawing.Size(458, 24);
            this.wiiKeySelectorDown.SystemKeyText = "None";
            this.wiiKeySelectorDown.TabIndex = 1;
            this.wiiKeySelectorDown.WiimoteKeyText = "Down";
            this.wiiKeySelectorDown.WindowsKeyText = "None";
            // 
            // wiiKeySelectorUp
            // 
            this.wiiKeySelectorUp.Location = new System.Drawing.Point(14, 40);
            this.wiiKeySelectorUp.MouseKeyText = "None";
            this.wiiKeySelectorUp.Name = "wiiKeySelectorUp";
            this.wiiKeySelectorUp.Size = new System.Drawing.Size(458, 24);
            this.wiiKeySelectorUp.SystemKeyText = "None";
            this.wiiKeySelectorUp.TabIndex = 0;
            this.wiiKeySelectorUp.WiimoteKeyText = "Up";
            this.wiiKeySelectorUp.WindowsKeyText = "None";
            // 
            // WiiController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.wiiKeySelectorTwo);
            this.Controls.Add(this.wiiKeySelectorOne);
            this.Controls.Add(this.wiiKeySelectorHome);
            this.Controls.Add(this.wiiKeySelectorPlus);
            this.Controls.Add(this.wiiKeySelectorMinus);
            this.Controls.Add(this.wiiKeySelectorB);
            this.Controls.Add(this.wiiKeySelectorA);
            this.Controls.Add(this.wiiKeySelectorRight);
            this.Controls.Add(this.wiiKeySelectorLeft);
            this.Controls.Add(this.wiiKeySelectorDown);
            this.Controls.Add(this.wiiKeySelectorUp);
            this.Name = "WiiController";
            this.Size = new System.Drawing.Size(486, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WiiKeySelector wiiKeySelectorUp;
        private WiiKeySelector wiiKeySelectorDown;
        private WiiKeySelector wiiKeySelectorLeft;
        private WiiKeySelector wiiKeySelectorRight;
        private WiiKeySelector wiiKeySelectorA;
        private WiiKeySelector wiiKeySelectorB;
        private WiiKeySelector wiiKeySelectorMinus;
        private WiiKeySelector wiiKeySelectorPlus;
        private WiiKeySelector wiiKeySelectorHome;
        private WiiKeySelector wiiKeySelectorOne;
        private WiiKeySelector wiiKeySelectorTwo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
