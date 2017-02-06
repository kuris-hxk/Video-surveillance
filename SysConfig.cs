using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using Microsoft.Win32;
 // 下载于www.csaspx.com
namespace RayVideo
{
    public partial class SysConfig : DevComponents.DotNetBar.OfficeForm
    {
        public SysConfig()
        {
            InitializeComponent();
        }

        private void OKbuttonX_Click(object sender, EventArgs e)
        {
            SaveSysConfig();
            this.Close();
        }
        private void SaveSysConfig()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("delete from sysconfig;");
            sb.Append(string.Format("insert into sysconfig (code,codevalue) values('FilePath','{0}');", filepathTxt.Text));
            sb.Append(string.Format("insert into sysconfig (code,codevalue) values('ShowCamerDevice','{0}');", checkBoxXShowCamerDevice.Checked));
            sb.Append(string.Format("insert into sysconfig (code,codevalue) values('AutoRun','{0}');", checkBoxXAutoRun.Checked));
            sb.Append(string.Format("insert into sysconfig (code,codevalue) values('AfterPhoto','{0}');", checkBoxXAfterPhoto.Checked));
            sb.Append(string.Format("insert into sysconfig (code,codevalue) values('AfterVideo','{0}');",checkBoxXAfterVideo.Checked));
           
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
            {
                if (checkBoxXAutoRun.Checked)
                {
                   key.SetValue("RayVideo", Application.ExecutablePath);
                }
                else
                {
                   if( key.GetValue("RayVideo")!=null)
                   key.DeleteValue("RayVideo", true);
                    
                }
            }
            sb.Append(string.Format("insert into sysconfig (code,codevalue) values('AutoVideo','{0}');", checkBoxXAutoVideo.Checked));
            SQLiteHelper.ExecuteNonQuery(sb.ToString());
            new SysConfigInfo().InitSysConfigInfo();
        }
        private void CancelbuttonX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SysConfig_Load(object sender, EventArgs e)
        {
            filepathTxt.Text = string.IsNullOrEmpty(SysConfigInfo.FilePath) ? Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\SaveFiles" : SysConfigInfo.FilePath;
            checkBoxXAutoRun.Checked = string.IsNullOrEmpty(SysConfigInfo.AutoRun) ? false : Convert.ToBoolean(SysConfigInfo.AutoRun);
            checkBoxXAutoVideo.Checked = string.IsNullOrEmpty(SysConfigInfo.AutoVideo) ? false : Convert.ToBoolean(SysConfigInfo.AutoVideo);
            checkBoxXShowCamerDevice.Checked = string.IsNullOrEmpty(SysConfigInfo.ShowCamerDevice) ? true : Convert.ToBoolean(SysConfigInfo.ShowCamerDevice);
            checkBoxXAfterPhoto.Checked = string.IsNullOrEmpty(SysConfigInfo.AfterPhoto) ? true : Convert.ToBoolean(SysConfigInfo.AfterPhoto);
            checkBoxXAfterVideo.Checked = string.IsNullOrEmpty(SysConfigInfo.AfterVideo) ? true : Convert.ToBoolean(SysConfigInfo.AfterVideo);
             
        }
    }
}