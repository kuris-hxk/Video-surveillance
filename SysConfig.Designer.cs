namespace RayVideo
{
    partial class SysConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysConfig));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxXShowCamerDevice = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.filepathTxt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxXAutoVideo = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxXAutoRun = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.OKbuttonX = new DevComponents.DotNetBar.ButtonX();
            this.CancelbuttonX = new DevComponents.DotNetBar.ButtonX();
            this.checkBoxXAfterVideo = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxXAfterPhoto = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxXAfterPhoto);
            this.groupBox1.Controls.Add(this.checkBoxXAfterVideo);
            this.groupBox1.Controls.Add(this.checkBoxXShowCamerDevice);
            this.groupBox1.Controls.Add(this.filepathTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "录像设置";
            // 
            // checkBoxXShowCamerDevice
            // 
            // 
            // 
            // 
            this.checkBoxXShowCamerDevice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxXShowCamerDevice.Checked = true;
            this.checkBoxXShowCamerDevice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxXShowCamerDevice.CheckValue = "Y";
            this.checkBoxXShowCamerDevice.Location = new System.Drawing.Point(18, 57);
            this.checkBoxXShowCamerDevice.Name = "checkBoxXShowCamerDevice";
            this.checkBoxXShowCamerDevice.Size = new System.Drawing.Size(137, 23);
            this.checkBoxXShowCamerDevice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxXShowCamerDevice.TabIndex = 2;
            this.checkBoxXShowCamerDevice.Text = "显示摄像设备选择框";
            // 
            // filepathTxt
            // 
            this.filepathTxt.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.filepathTxt.Border.Class = "TextBoxBorder";
            this.filepathTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.filepathTxt.DisabledBackColor = System.Drawing.Color.White;
            this.filepathTxt.ForeColor = System.Drawing.Color.Black;
            this.filepathTxt.Location = new System.Drawing.Point(96, 30);
            this.filepathTxt.Name = "filepathTxt";
            this.filepathTxt.PreventEnterBeep = true;
            this.filepathTxt.Size = new System.Drawing.Size(301, 21);
            this.filepathTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件保存位置:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxXAutoVideo);
            this.groupBox2.Controls.Add(this.checkBoxXAutoRun);
            this.groupBox2.Location = new System.Drawing.Point(21, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "启动设置";
            // 
            // checkBoxXAutoVideo
            // 
            // 
            // 
            // 
            this.checkBoxXAutoVideo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxXAutoVideo.Location = new System.Drawing.Point(153, 31);
            this.checkBoxXAutoVideo.Name = "checkBoxXAutoVideo";
            this.checkBoxXAutoVideo.Size = new System.Drawing.Size(149, 23);
            this.checkBoxXAutoVideo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxXAutoVideo.TabIndex = 1;
            this.checkBoxXAutoVideo.Text = "软件启动后自动录像";
            // 
            // checkBoxXAutoRun
            // 
            // 
            // 
            // 
            this.checkBoxXAutoRun.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxXAutoRun.Location = new System.Drawing.Point(29, 31);
            this.checkBoxXAutoRun.Name = "checkBoxXAutoRun";
            this.checkBoxXAutoRun.Size = new System.Drawing.Size(100, 23);
            this.checkBoxXAutoRun.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxXAutoRun.TabIndex = 0;
            this.checkBoxXAutoRun.Text = "开机自动运行";
            // 
            // OKbuttonX
            // 
            this.OKbuttonX.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.OKbuttonX.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.OKbuttonX.Location = new System.Drawing.Point(279, 275);
            this.OKbuttonX.Name = "OKbuttonX";
            this.OKbuttonX.Size = new System.Drawing.Size(75, 23);
            this.OKbuttonX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.OKbuttonX.TabIndex = 2;
            this.OKbuttonX.Text = "确定";
            this.OKbuttonX.Click += new System.EventHandler(this.OKbuttonX_Click);
            // 
            // CancelbuttonX
            // 
            this.CancelbuttonX.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CancelbuttonX.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CancelbuttonX.Location = new System.Drawing.Point(377, 275);
            this.CancelbuttonX.Name = "CancelbuttonX";
            this.CancelbuttonX.Size = new System.Drawing.Size(75, 23);
            this.CancelbuttonX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CancelbuttonX.TabIndex = 3;
            this.CancelbuttonX.Text = "取消";
            this.CancelbuttonX.Click += new System.EventHandler(this.CancelbuttonX_Click);
            // 
            // checkBoxXAfterVideo
            // 
            // 
            // 
            // 
            this.checkBoxXAfterVideo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxXAfterVideo.Location = new System.Drawing.Point(165, 57);
            this.checkBoxXAfterVideo.Name = "checkBoxXAfterVideo";
            this.checkBoxXAfterVideo.Size = new System.Drawing.Size(168, 23);
            this.checkBoxXAfterVideo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxXAfterVideo.TabIndex = 3;
            this.checkBoxXAfterVideo.Text = "停止录像打开文件夹";
            // 
            // checkBoxXAfterPhoto
            // 
            // 
            // 
            // 
            this.checkBoxXAfterPhoto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxXAfterPhoto.Location = new System.Drawing.Point(18, 86);
            this.checkBoxXAfterPhoto.Name = "checkBoxXAfterPhoto";
            this.checkBoxXAfterPhoto.Size = new System.Drawing.Size(137, 23);
            this.checkBoxXAfterPhoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxXAfterPhoto.TabIndex = 4;
            this.checkBoxXAfterPhoto.Text = "拍照后打开文件夹";
            // 
            // SysConfig
            // 
            this.ClientSize = new System.Drawing.Size(487, 311);
            this.Controls.Add(this.CancelbuttonX);
            this.Controls.Add(this.OKbuttonX);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SysConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选项设置";
            this.Load += new System.EventHandler(this.SysConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX filepathTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxXAutoVideo;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxXAutoRun;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxXShowCamerDevice;
        private DevComponents.DotNetBar.ButtonX OKbuttonX;
        private DevComponents.DotNetBar.ButtonX CancelbuttonX;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxXAfterPhoto;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxXAfterVideo;
    }
}