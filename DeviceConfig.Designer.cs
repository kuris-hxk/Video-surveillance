namespace RayVideo
{
    partial class DeviceConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceConfig));
            this.MCtextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.FBLcomboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.OKbutton = new DevComponents.DotNetBar.ButtonX();
            this.Cancelbutton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // MCtextBox
            // 
            this.MCtextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MCtextBox.Border.Class = "TextBoxBorder";
            this.MCtextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MCtextBox.DisabledBackColor = System.Drawing.Color.White;
            this.MCtextBox.ForeColor = System.Drawing.Color.Black;
            this.MCtextBox.Location = new System.Drawing.Point(98, 22);
            this.MCtextBox.Name = "MCtextBox";
            this.MCtextBox.PreventEnterBeep = true;
            this.MCtextBox.Size = new System.Drawing.Size(350, 22);
            this.MCtextBox.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(13, 20);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 24);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "摄像头名称:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 61);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "分辨率:";
            // 
            // FBLcomboBox
            // 
            this.FBLcomboBox.DisplayMember = "Text";
            this.FBLcomboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FBLcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FBLcomboBox.ForeColor = System.Drawing.Color.Black;
            this.FBLcomboBox.FormattingEnabled = true;
            this.FBLcomboBox.ItemHeight = 16;
            this.FBLcomboBox.Location = new System.Drawing.Point(98, 61);
            this.FBLcomboBox.Name = "FBLcomboBox";
            this.FBLcomboBox.Size = new System.Drawing.Size(168, 22);
            this.FBLcomboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.FBLcomboBox.TabIndex = 4;
            // 
            // OKbutton
            // 
            this.OKbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.OKbutton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.OKbutton.Location = new System.Drawing.Point(330, 134);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.OKbutton.TabIndex = 5;
            this.OKbutton.Text = "确定";
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Cancelbutton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Cancelbutton.Location = new System.Drawing.Point(423, 134);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Cancelbutton.TabIndex = 6;
            this.Cancelbutton.Text = "取消";
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // DeviceConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 178);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.FBLcomboBox);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.MCtextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "DeviceConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "属性设置";
            this.Load += new System.EventHandler(this.DeviceConfig_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX MCtextBox;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx FBLcomboBox;
        private DevComponents.DotNetBar.ButtonX OKbutton;
        private DevComponents.DotNetBar.ButtonX Cancelbutton;
    }
}