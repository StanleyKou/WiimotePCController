namespace WiiPC
{
    partial class MainWindow
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBattery = new System.Windows.Forms.ToolStripProgressBar();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllSettingSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.옵션OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySettingChangedDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySettingLightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wiiTabCtrl = new System.Windows.Forms.TabControl();
            this.CtrlPage1 = new System.Windows.Forms.TabPage();
            this.wiiController1 = new WiiPC.WiiController();
            this.CtrlPage2 = new System.Windows.Forms.TabPage();
            this.wiiController2 = new WiiPC.WiiController();
            this.CtrlPage3 = new System.Windows.Forms.TabPage();
            this.wiiController3 = new WiiPC.WiiController();
            this.CtrlPage4 = new System.Windows.Forms.TabPage();
            this.wiiController4 = new WiiPC.WiiController();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.labelStatus4 = new System.Windows.Forms.Label();
            this.labelStatus3 = new System.Windows.Forms.Label();
            this.labelW4 = new System.Windows.Forms.Label();
            this.labelW3 = new System.Windows.Forms.Label();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.labelSetting = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelW2 = new System.Windows.Forms.Label();
            this.labelW1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.progressBattery2 = new System.Windows.Forms.ToolStripProgressBar();
            this.progressBattery3 = new System.Windows.Forms.ToolStripProgressBar();
            this.progressBattery4 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusBar.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.wiiTabCtrl.SuspendLayout();
            this.CtrlPage1.SuspendLayout();
            this.CtrlPage2.SuspendLayout();
            this.CtrlPage3.SuspendLayout();
            this.CtrlPage4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progressBattery,
            this.progressBattery2,
            this.progressBattery3,
            this.progressBattery4});
            this.statusBar.Location = new System.Drawing.Point(0, 553);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(509, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "  ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "Battery : ";
            // 
            // progressBattery
            // 
            this.progressBattery.Name = "progressBattery";
            this.progressBattery.Size = new System.Drawing.Size(100, 16);
            this.progressBattery.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.옵션OToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(509, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectCToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.saveAllSettingSToolStripMenuItem,
            this.toolStripSeparator1,
            this.끝내기XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.파일FToolStripMenuItem.Text = "File(&F)";
            // 
            // connectCToolStripMenuItem
            // 
            this.connectCToolStripMenuItem.Name = "connectCToolStripMenuItem";
            this.connectCToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.connectCToolStripMenuItem.Text = "Connect(&C)";
            this.connectCToolStripMenuItem.Click += new System.EventHandler(this.connectCToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect(&D)";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // saveAllSettingSToolStripMenuItem
            // 
            this.saveAllSettingSToolStripMenuItem.Name = "saveAllSettingSToolStripMenuItem";
            this.saveAllSettingSToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveAllSettingSToolStripMenuItem.Text = "Save All Setting(&S)";
            this.saveAllSettingSToolStripMenuItem.Click += new System.EventHandler(this.saveAllSettingSToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // 끝내기XToolStripMenuItem
            // 
            this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
            this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.끝내기XToolStripMenuItem.Text = "Exit(&X)";
            this.끝내기XToolStripMenuItem.Click += new System.EventHandler(this.끝내기XToolStripMenuItem_Click);
            // 
            // 옵션OToolStripMenuItem
            // 
            this.옵션OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displaySettingChangedDToolStripMenuItem,
            this.displaySettingLightToolStripMenuItem});
            this.옵션OToolStripMenuItem.Name = "옵션OToolStripMenuItem";
            this.옵션OToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.옵션OToolStripMenuItem.Text = "Option(&O)";
            // 
            // displaySettingChangedDToolStripMenuItem
            // 
            this.displaySettingChangedDToolStripMenuItem.Checked = true;
            this.displaySettingChangedDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displaySettingChangedDToolStripMenuItem.Name = "displaySettingChangedDToolStripMenuItem";
            this.displaySettingChangedDToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.displaySettingChangedDToolStripMenuItem.Text = "Display Setting Changed(&D)";
            this.displaySettingChangedDToolStripMenuItem.Click += new System.EventHandler(this.displaySettingChangedDToolStripMenuItem_Click_1);
            // 
            // displaySettingLightToolStripMenuItem
            // 
            this.displaySettingLightToolStripMenuItem.Checked = true;
            this.displaySettingLightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displaySettingLightToolStripMenuItem.Name = "displaySettingLightToolStripMenuItem";
            this.displaySettingLightToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.displaySettingLightToolStripMenuItem.Text = "Display Setting Light";
            this.displaySettingLightToolStripMenuItem.CheckedChanged += new System.EventHandler(this.displaySettingLightToolStripMenuItem_CheckedChanged);
            this.displaySettingLightToolStripMenuItem.Click += new System.EventHandler(this.displaySettingLightToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpToolStripMenuItem.Text = "Help(&H)";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // wiiTabCtrl
            // 
            this.wiiTabCtrl.Controls.Add(this.CtrlPage1);
            this.wiiTabCtrl.Controls.Add(this.CtrlPage2);
            this.wiiTabCtrl.Controls.Add(this.CtrlPage3);
            this.wiiTabCtrl.Controls.Add(this.CtrlPage4);
            this.wiiTabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wiiTabCtrl.Location = new System.Drawing.Point(0, 87);
            this.wiiTabCtrl.Margin = new System.Windows.Forms.Padding(0);
            this.wiiTabCtrl.Name = "wiiTabCtrl";
            this.wiiTabCtrl.SelectedIndex = 0;
            this.wiiTabCtrl.Size = new System.Drawing.Size(509, 464);
            this.wiiTabCtrl.TabIndex = 2;
            // 
            // CtrlPage1
            // 
            this.CtrlPage1.BackColor = System.Drawing.SystemColors.Control;
            this.CtrlPage1.Controls.Add(this.wiiController1);
            this.CtrlPage1.Location = new System.Drawing.Point(4, 22);
            this.CtrlPage1.Margin = new System.Windows.Forms.Padding(0);
            this.CtrlPage1.Name = "CtrlPage1";
            this.CtrlPage1.Size = new System.Drawing.Size(501, 438);
            this.CtrlPage1.TabIndex = 0;
            this.CtrlPage1.Text = "Setting 1";
            // 
            // wiiController1
            // 
            this.wiiController1.ControllerChanger = null;
            this.wiiController1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wiiController1.Location = new System.Drawing.Point(0, 0);
            this.wiiController1.Margin = new System.Windows.Forms.Padding(0);
            this.wiiController1.Name = "wiiController1";
            this.wiiController1.No = 1;
            this.wiiController1.Size = new System.Drawing.Size(501, 438);
            this.wiiController1.TabIndex = 0;
            // 
            // CtrlPage2
            // 
            this.CtrlPage2.BackColor = System.Drawing.SystemColors.Control;
            this.CtrlPage2.Controls.Add(this.wiiController2);
            this.CtrlPage2.Location = new System.Drawing.Point(4, 22);
            this.CtrlPage2.Margin = new System.Windows.Forms.Padding(0);
            this.CtrlPage2.Name = "CtrlPage2";
            this.CtrlPage2.Size = new System.Drawing.Size(501, 438);
            this.CtrlPage2.TabIndex = 1;
            this.CtrlPage2.Text = "Setting 2";
            // 
            // wiiController2
            // 
            this.wiiController2.ControllerChanger = null;
            this.wiiController2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wiiController2.Location = new System.Drawing.Point(0, 0);
            this.wiiController2.Margin = new System.Windows.Forms.Padding(0);
            this.wiiController2.Name = "wiiController2";
            this.wiiController2.No = 2;
            this.wiiController2.Size = new System.Drawing.Size(501, 438);
            this.wiiController2.TabIndex = 0;
            // 
            // CtrlPage3
            // 
            this.CtrlPage3.BackColor = System.Drawing.SystemColors.Control;
            this.CtrlPage3.Controls.Add(this.wiiController3);
            this.CtrlPage3.Location = new System.Drawing.Point(4, 22);
            this.CtrlPage3.Margin = new System.Windows.Forms.Padding(0);
            this.CtrlPage3.Name = "CtrlPage3";
            this.CtrlPage3.Size = new System.Drawing.Size(501, 438);
            this.CtrlPage3.TabIndex = 2;
            this.CtrlPage3.Text = "Setting 3";
            // 
            // wiiController3
            // 
            this.wiiController3.ControllerChanger = null;
            this.wiiController3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wiiController3.Location = new System.Drawing.Point(0, 0);
            this.wiiController3.Margin = new System.Windows.Forms.Padding(0);
            this.wiiController3.Name = "wiiController3";
            this.wiiController3.No = 3;
            this.wiiController3.Size = new System.Drawing.Size(501, 438);
            this.wiiController3.TabIndex = 0;
            // 
            // CtrlPage4
            // 
            this.CtrlPage4.BackColor = System.Drawing.SystemColors.Control;
            this.CtrlPage4.Controls.Add(this.wiiController4);
            this.CtrlPage4.Location = new System.Drawing.Point(4, 22);
            this.CtrlPage4.Margin = new System.Windows.Forms.Padding(0);
            this.CtrlPage4.Name = "CtrlPage4";
            this.CtrlPage4.Size = new System.Drawing.Size(501, 438);
            this.CtrlPage4.TabIndex = 3;
            this.CtrlPage4.Text = "Setting 4";
            // 
            // wiiController4
            // 
            this.wiiController4.ControllerChanger = null;
            this.wiiController4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wiiController4.Location = new System.Drawing.Point(0, 0);
            this.wiiController4.Margin = new System.Windows.Forms.Padding(0);
            this.wiiController4.Name = "wiiController4";
            this.wiiController4.No = 4;
            this.wiiController4.Size = new System.Drawing.Size(501, 438);
            this.wiiController4.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Wiimote PC Controller";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitXToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 26);
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitXToolStripMenuItem.Text = "Exit(&X)";
            this.exitXToolStripMenuItem.Click += new System.EventHandler(this.exitXToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wiiTabCtrl);
            this.panel1.Controls.Add(this.groupBoxStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 551);
            this.panel1.TabIndex = 5;
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.labelStatus4);
            this.groupBoxStatus.Controls.Add(this.labelStatus3);
            this.groupBoxStatus.Controls.Add(this.labelW4);
            this.groupBoxStatus.Controls.Add(this.labelW3);
            this.groupBoxStatus.Controls.Add(this.labelStatus2);
            this.groupBoxStatus.Controls.Add(this.labelSetting);
            this.groupBoxStatus.Controls.Add(this.label2);
            this.groupBoxStatus.Controls.Add(this.labelW2);
            this.groupBoxStatus.Controls.Add(this.labelW1);
            this.groupBoxStatus.Controls.Add(this.labelStatus);
            this.groupBoxStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(509, 87);
            this.groupBoxStatus.TabIndex = 1;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // labelStatus4
            // 
            this.labelStatus4.AutoSize = true;
            this.labelStatus4.Location = new System.Drawing.Point(358, 63);
            this.labelStatus4.Name = "labelStatus4";
            this.labelStatus4.Size = new System.Drawing.Size(82, 12);
            this.labelStatus4.TabIndex = 8;
            this.labelStatus4.Text = "Disconnected";
            // 
            // labelStatus3
            // 
            this.labelStatus3.AutoSize = true;
            this.labelStatus3.Location = new System.Drawing.Point(358, 40);
            this.labelStatus3.Name = "labelStatus3";
            this.labelStatus3.Size = new System.Drawing.Size(82, 12);
            this.labelStatus3.TabIndex = 7;
            this.labelStatus3.Text = "Disconnected";
            // 
            // labelW4
            // 
            this.labelW4.AutoSize = true;
            this.labelW4.Location = new System.Drawing.Point(264, 63);
            this.labelW4.Name = "labelW4";
            this.labelW4.Size = new System.Drawing.Size(87, 12);
            this.labelW4.TabIndex = 6;
            this.labelW4.Text = "W4 (Setting4) :";
            // 
            // labelW3
            // 
            this.labelW3.AutoSize = true;
            this.labelW3.Location = new System.Drawing.Point(264, 40);
            this.labelW3.Name = "labelW3";
            this.labelW3.Size = new System.Drawing.Size(87, 12);
            this.labelW3.TabIndex = 5;
            this.labelW3.Text = "W3 (Setting3) :";
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Location = new System.Drawing.Point(358, 17);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(82, 12);
            this.labelStatus2.TabIndex = 4;
            this.labelStatus2.Text = "Disconnected";
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(95, 53);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(53, 12);
            this.labelSetting.TabIndex = 3;
            this.labelSetting.Text = "Setting 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Controller:";
            // 
            // labelW2
            // 
            this.labelW2.AutoSize = true;
            this.labelW2.Location = new System.Drawing.Point(264, 17);
            this.labelW2.Name = "labelW2";
            this.labelW2.Size = new System.Drawing.Size(87, 12);
            this.labelW2.TabIndex = 1;
            this.labelW2.Text = "W2 (Setting2) :";
            // 
            // labelW1
            // 
            this.labelW1.AutoSize = true;
            this.labelW1.Location = new System.Drawing.Point(6, 28);
            this.labelW1.Name = "labelW1";
            this.labelW1.Size = new System.Drawing.Size(83, 12);
            this.labelW1.TabIndex = 1;
            this.labelW1.Text = "W1 (Setting1):";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(95, 28);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(82, 12);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Disconnected";
            // 
            // progressBattery2
            // 
            this.progressBattery2.Name = "progressBattery2";
            this.progressBattery2.Size = new System.Drawing.Size(100, 16);
            this.progressBattery2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // progressBattery3
            // 
            this.progressBattery3.Name = "progressBattery3";
            this.progressBattery3.Size = new System.Drawing.Size(100, 16);
            this.progressBattery3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // progressBattery4
            // 
            this.progressBattery4.Name = "progressBattery4";
            this.progressBattery4.Size = new System.Drawing.Size(100, 16);
            this.progressBattery4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 575);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wiimote PC Controller v1.1";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.wiiTabCtrl.ResumeLayout(false);
            this.CtrlPage1.ResumeLayout(false);
            this.CtrlPage2.ResumeLayout(false);
            this.CtrlPage3.ResumeLayout(false);
            this.CtrlPage4.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 옵션OToolStripMenuItem;
        private System.Windows.Forms.TabControl wiiTabCtrl;
        private System.Windows.Forms.TabPage CtrlPage1;
        private System.Windows.Forms.TabPage CtrlPage2;
        private System.Windows.Forms.TabPage CtrlPage3;
        private System.Windows.Forms.TabPage CtrlPage4;
        private WiiController wiiController1;
        private WiiController wiiController2;
        private WiiController wiiController3;
        private WiiController wiiController4;
        private System.Windows.Forms.ToolStripMenuItem displaySettingChangedDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllSettingSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem displaySettingLightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progressBattery;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelW1;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label labelStatus4;
        private System.Windows.Forms.Label labelStatus3;
        private System.Windows.Forms.Label labelW4;
        private System.Windows.Forms.Label labelW3;
        private System.Windows.Forms.Label labelStatus2;
        private System.Windows.Forms.Label labelW2;
        private System.Windows.Forms.ToolStripProgressBar progressBattery2;
        private System.Windows.Forms.ToolStripProgressBar progressBattery3;
        private System.Windows.Forms.ToolStripProgressBar progressBattery4;


    }
}

