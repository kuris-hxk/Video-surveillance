
namespace RayVideo
{
    partial class MainPage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.videoBtnItem = new DevComponents.DotNetBar.ButtonItem();
            this.stopVideBtnItem = new DevComponents.DotNetBar.ButtonItem();
            this.pictureBtnItem = new DevComponents.DotNetBar.ButtonItem();
            this.filePpath = new DevComponents.DotNetBar.ButtonItem();
            this.bar3 = new DevComponents.DotNetBar.Bar();
            this.videoBtn = new DevComponents.DotNetBar.ButtonItem();
            this.stopVideBtn = new DevComponents.DotNetBar.ButtonItem();
            this.pictureBtn = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar3)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.MenuBar = true;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(750, 26);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 10;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ForeColor = System.Drawing.Color.Black;
            this.buttonItem1.HotForeColor = System.Drawing.Color.Black;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO);
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.videoBtnItem,
            this.stopVideBtnItem,
            this.pictureBtnItem,
            this.filePpath});
            this.buttonItem1.Text = "操作";
            // 
            // videoBtnItem
            // 
            this.videoBtnItem.ForeColor = System.Drawing.Color.Black;
            this.videoBtnItem.Name = "videoBtnItem";
            this.videoBtnItem.Text = "开始录像";
            this.videoBtnItem.Click += new System.EventHandler(this.videoBtnItem_Click);
            // 
            // stopVideBtnItem
            // 
            this.stopVideBtnItem.ForeColor = System.Drawing.Color.Black;
            this.stopVideBtnItem.Name = "stopVideBtnItem";
            this.stopVideBtnItem.Text = "停止录像";
            this.stopVideBtnItem.Click += new System.EventHandler(this.stopVideBtnItem_Click);
            // 
            // pictureBtnItem
            // 
            this.pictureBtnItem.ForeColor = System.Drawing.Color.Black;
            this.pictureBtnItem.Name = "pictureBtnItem";
            this.pictureBtnItem.Text = "拍取照片";
            this.pictureBtnItem.Click += new System.EventHandler(this.pictureBtnItem_Click);
            // 
            // filePpath
            // 
            this.filePpath.ForeColor = System.Drawing.Color.Black;
            this.filePpath.Name = "filePpath";
            this.filePpath.Text = "文件路径";
            this.filePpath.Click += new System.EventHandler(this.filePpath_Click);
            // 
            // bar3
            // 
            this.bar3.AccessibleDescription = "DotNetBar Bar (bar3)";
            this.bar3.AccessibleName = "DotNetBar Bar";
            this.bar3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bar3.AntiAlias = true;
            this.bar3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.videoBtn,
            this.stopVideBtn,
            this.pictureBtn,
            this.buttonItem8});
            this.bar3.Location = new System.Drawing.Point(0, 26);
            this.bar3.MenuBar = true;
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(750, 74);
            this.bar3.Stretch = true;
            this.bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar3.TabIndex = 12;
            this.bar3.TabStop = false;
            this.bar3.Text = "bar3";
            // 
            // videoBtn
            // 
            this.videoBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.videoBtn.ForeColor = System.Drawing.Color.Black;
            this.videoBtn.Image = ((System.Drawing.Image)(resources.GetObject("videoBtn.Image")));
            this.videoBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.videoBtn.Name = "videoBtn";
            this.videoBtn.Text = "开始录像          ";
            this.videoBtn.Click += new System.EventHandler(this.videoBtn_Click);
            // 
            // stopVideBtn
            // 
            this.stopVideBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.stopVideBtn.ForeColor = System.Drawing.Color.Black;
            this.stopVideBtn.Image = ((System.Drawing.Image)(resources.GetObject("stopVideBtn.Image")));
            this.stopVideBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.stopVideBtn.Name = "stopVideBtn";
            this.stopVideBtn.Text = "停止录像";
            this.stopVideBtn.Click += new System.EventHandler(this.stopVideBtn_Click);
            // 
            // pictureBtn
            // 
            this.pictureBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.pictureBtn.ForeColor = System.Drawing.Color.Black;
            this.pictureBtn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBtn.Image")));
            this.pictureBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.pictureBtn.Name = "pictureBtn";
            this.pictureBtn.Text = "拍摄照片";
            this.pictureBtn.Click += new System.EventHandler(this.pictureBtn_Click);
            // 
            // buttonItem8
            // 
            this.buttonItem8.ForeColor = System.Drawing.Color.Black;
            this.buttonItem8.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem8.Image")));
            this.buttonItem8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.Text = "选项设置";
            this.buttonItem8.Click += new System.EventHandler(this.buttonItem8_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 561);
            this.Controls.Add(this.bar3);
            this.Controls.Add(this.bar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "视频监控";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainPage_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.Bar bar3;
        private DevComponents.DotNetBar.ButtonItem videoBtn;
        private DevComponents.DotNetBar.ButtonItem stopVideBtn;
        private DevComponents.DotNetBar.ButtonItem pictureBtn;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem videoBtnItem;
        private DevComponents.DotNetBar.ButtonItem stopVideBtnItem;
        private DevComponents.DotNetBar.ButtonItem pictureBtnItem;
        private DevComponents.DotNetBar.ButtonItem filePpath;
    }
}

