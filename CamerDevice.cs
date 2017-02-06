using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using AForge.Video.DirectShow;
using AForge.Controls;

namespace RayVideo
{
    public partial class CamerDevice : DevComponents.DotNetBar.OfficeForm
    {
        public FilterInfoCollection videoDevices;
        public DataTable dt;
        public IList<VideoCaptureDevice> videoCaptureDevicelist = new List<VideoCaptureDevice>();
        bool appliactionclose = true;
        MainPage mainPage;
        public CamerDevice(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
           
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            foreach (VideoCaptureDevice item in videoCaptureDevicelist)
            {
                item.SignalToStop();
                item.WaitForStop();
            }
            this.Close();
            mainPage.CloseAppliaction();
         
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            SaveCamerDevice();
            int count =  videoDevices.Count;
            appliactionclose = false;
            int columns = 4;
            mainPage.tablepanel.AutoScroll = true;
            mainPage.tablepanel.Top = 105;
            mainPage.tablepanel.Left=2;
            mainPage.tablepanel.Width = mainPage.Width-17;
            mainPage.tablepanel.Height = mainPage.Height -140;
            //mainPage.tablepanel.Dock = DockStyle.Fill;
           
            mainPage.Controls.Add(mainPage.tablepanel);
            mainPage.tablepanel.ColumnCount = columns;
            mainPage.tablepanel.RowCount = count % columns == 0 ? count / columns : count/columns+1;
            for (int i = 0; i < count; i++)
            {
                mainPage.AddCamerItem(i,columns);
            }
          
            this.Close();
            
        }
        private void SaveCamerDevice()
        {
            foreach (DataRow dr in dt.Rows)
            {
                SQLiteHelper sqlhelper = new SQLiteHelper();
                string sqlExists = string.Format("  SELECT count(0) FROM camerDevice WHERE deviceID='{0}'", dr[3]);
                int count = Convert.ToInt32(SQLiteHelper.ExecuteScalar(sqlExists));
                string sql;
                if (count == 0)
                {
                    sql = string.Format("  insert into camerDevice (name,frameSize,deviceID,frameSizeIndex) values('{0}','{1}','{2}','{3}')",
                    dr[0], dr[1], dr[3], dr[4]);
                }
                else
                {
                    sql = string.Format(" update camerDevice set name='{0}',frameSize='{1}',frameSizeIndex='{3}' WHERE deviceID='{2}'",
                    dr[0], dr[1], dr[3], dr[4]);

                }

                SQLiteHelper.ExecuteNonQuery(sql);
            }
        }
        private DataTable GetCamera()
        {
            DataTable ds = SQLiteHelper.ExecuteQuery("select name,frameSize,deviceID,frameSizeIndex from camerDevice").Tables[0];
                
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
           
            mainPage.videoDevices = videoDevices;
            if (videoDevices.Count == 0)
                return null;
            string[] columns = { "摄像头名称", "分辨率", "摄像头设置","设备标示","分辨率索引" };
            dt = new DataTable();
            for (int count = 0; count < columns.Length; count++)
            {
                DataColumn dc = new DataColumn(columns[count]);
                dt.Columns.Add(dc);
            }

            foreach (FilterInfo device in videoDevices)
            {
                VideoCaptureDevice videoDevice = new VideoCaptureDevice(device.MonikerString);//摄像头的名称
                 DataRow []ds_dr= ds.Select("deviceID='" + device.MonikerString + "'");
                Size framesize = videoDevice.VideoCapabilities[0].FrameSize;
                videoCaptureDevicelist.Add(videoDevice);
                DataRow dr = dt.NewRow();
               for (int countsub = 0; countsub < columns.Length; countsub++)
                {
                   
                    switch (countsub)
                    {
                        case 0: dr[countsub] =ds_dr.Length>0?ds_dr[0]["name"]: Convert.ToString(device.Name); break;
                        case 1: dr[countsub] =ds_dr.Length>0?ds_dr[0]["frameSize"]: framesize.Width + "×" + framesize.Height; break;
                        case 2: dr[countsub] ="点击设置属性"; break;
                        case 3: dr[countsub] = device.MonikerString; break;
                        case 4: dr[countsub] = ds_dr.Length>0?ds_dr[0]["frameSizeIndex"]:"0"; break;
                            
                    }
                   
                   
                }
                dt.Rows.Add(dr);
            }

          
            return dt;
           
            
             
        }
        private void SetProperty()
        {
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);//摄像头的名称
            if ((videoSource != null) && (videoSource is VideoCaptureDevice))
            {
              
                
                try
                {
                    ((VideoCaptureDevice)videoSource).DisplayPropertyPage(this.Handle);
                }
                catch (NotSupportedException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CamerDevice_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn ck = new DataGridViewCheckBoxColumn();
           
            devicedataGridViewX.Columns.Add(ck);
            devicedataGridViewX.Columns[0].Width = 30;
            DataTable dt = GetCamera();
            if (dt==null||dt.Rows.Count == 0)
            {
                OkBtn.Enabled = false;
              
                MessageBox.Show("无法检测到摄像设备!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            devicedataGridViewX.DataSource = dt;
            devicedataGridViewX.Columns[1].Width = 200;
            devicedataGridViewX.Columns[1].ReadOnly = true;
            devicedataGridViewX.Columns[2].ReadOnly = true;
            devicedataGridViewX.Columns[3].ReadOnly = true;
            devicedataGridViewX.Columns[3].DefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleCenter;
            devicedataGridViewX.Columns[3].DefaultCellStyle.ForeColor = Color.FromArgb(59, 132, 215);
            devicedataGridViewX.Columns[4].Visible = false;
            devicedataGridViewX.Columns[5].Visible = false;
            for (int i = 0; i < devicedataGridViewX.Rows.Count; i++)
            {
                devicedataGridViewX.Rows[i].Cells[0].Value = true;
                

            }
        }

        private void devicedataGridViewX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==3)
            {
              //  SetProperty();
                SetDeviceConfig(e);
            }
        }
        private void SetDeviceConfig(DataGridViewCellEventArgs e)
        {

            DeviceConfig _deviceConfig = new DeviceConfig(this, e.RowIndex);
            _deviceConfig.FBList.Clear();
            int index = 0;
            foreach (VideoCapabilities item in videoCaptureDevicelist[e.RowIndex].VideoCapabilities)
            {
                ComData tmp = new ComData();
                tmp.Code = index;
                tmp.Name = item.FrameSize.Width + "×" + item.FrameSize.Height;
                _deviceConfig.FBList.Add(tmp);
                index++;
            }
            _deviceConfig.FBStr = dt.Rows[e.RowIndex][1].ToString();
            _deviceConfig.MCStr = dt.Rows[e.RowIndex][0].ToString();
            _deviceConfig.deviceID = dt.Rows[e.RowIndex][3].ToString();
            _deviceConfig.ShowDialog();
        
        }

        private void devicedataGridViewX_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CamerDevice_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (appliactionclose)
            {
                foreach (VideoCaptureDevice item in videoCaptureDevicelist)
                {
                    item.SignalToStop();
                    item.WaitForStop();
                }
                Application.Exit();
            }
        }

       
    }
}