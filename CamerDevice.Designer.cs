namespace RayVideo
{
    partial class CamerDevice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CamerDevice));
            this.devicedataGridViewX = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.OkBtn = new DevComponents.DotNetBar.ButtonX();
            this.CancelBtn = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.devicedataGridViewX)).BeginInit();
            this.SuspendLayout();
            // 
            // devicedataGridViewX
            // 
            this.devicedataGridViewX.AllowUserToAddRows = false;
            this.devicedataGridViewX.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.devicedataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.devicedataGridViewX.DefaultCellStyle = dataGridViewCellStyle1;
            this.devicedataGridViewX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.devicedataGridViewX.Location = new System.Drawing.Point(-3, 0);
            this.devicedataGridViewX.Name = "devicedataGridViewX";
            this.devicedataGridViewX.RowHeadersVisible = false;
            this.devicedataGridViewX.RowTemplate.Height = 23;
            this.devicedataGridViewX.Size = new System.Drawing.Size(463, 150);
            this.devicedataGridViewX.TabIndex = 0;
            this.devicedataGridViewX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devicedataGridViewX_CellContentClick);
            this.devicedataGridViewX.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devicedataGridViewX_CellDoubleClick);
            // 
            // OkBtn
            // 
            this.OkBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.OkBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.OkBtn.Location = new System.Drawing.Point(260, 156);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "确定";
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CancelBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CancelBtn.Location = new System.Drawing.Point(361, 156);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CamerDevice
            // 
            this.ClientSize = new System.Drawing.Size(458, 184);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.devicedataGridViewX);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CamerDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请选择视频设备";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CamerDevice_FormClosed);
            this.Load += new System.EventHandler(this.CamerDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.devicedataGridViewX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX devicedataGridViewX;
        private DevComponents.DotNetBar.ButtonX OkBtn;
        private DevComponents.DotNetBar.ButtonX CancelBtn;
    }
}