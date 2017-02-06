using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace RayVideo
{
   
    public partial class DeviceConfig : DevComponents.DotNetBar.OfficeForm
    {
        CamerDevice camerDevice;
        int RowIndex;
        public string MCStr;
        public string FBStr;
        public string deviceID;
        public IList<ComData> FBList = new List<ComData>();
        public DeviceConfig(CamerDevice camerDevice,int RowIndex)
        {
            this.camerDevice = camerDevice;
            this.RowIndex = RowIndex;
            InitializeComponent();
        }
        public void InitData()
        {

            MCtextBox.Text = MCStr;
            this.FBLcomboBox.DataSource = FBList;
            this.FBLcomboBox.ValueMember = "code";
            this.FBLcomboBox.DisplayMember = "name";
            this.FBLcomboBox.Text = FBStr;  
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            camerDevice.dt.Rows[RowIndex][0] = MCtextBox.Text;
            camerDevice.dt.Rows[RowIndex][1] = FBLcomboBox.Text;
            camerDevice.dt.Rows[RowIndex][4] = FBLcomboBox.SelectedValue;
            this.Close();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeviceConfig_Load(object sender, EventArgs e)
        {
            InitData();
        }
      
    }
}