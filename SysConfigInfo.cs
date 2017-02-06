using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayVideo
{
    public   class SysConfigInfo
    {
        public static string FilePath { get; set; }
        public static string ShowCamerDevice { get; set; }
        public static string AutoRun { get; set; }
        public static string AutoVideo { get; set; }

         public static string AfterPhoto { get; set; }
         public static string AfterVideo { get; set; }

            
        public  void InitSysConfigInfo()
        {
            string sqlExists = string.Format("SELECT * FROM sysconfig");
            DataTable ds = SQLiteHelper.ExecuteQuery(sqlExists).Tables[0];
            foreach (DataRow dr in ds.Rows)
            {
                switch (dr["Code"].ToString())
                {
                    case "FilePath": FilePath = dr["CodeValue"].ToString(); break;
                    case "ShowCamerDevice": ShowCamerDevice = dr["CodeValue"].ToString(); break;
                    case "AutoRun": AutoRun = dr["CodeValue"].ToString(); break;
                    case "AutoVideo": AutoVideo = dr["CodeValue"].ToString(); break;
                    case "AfterPhoto": AfterPhoto = dr["CodeValue"].ToString(); break;
                    case "AfterVideo": AfterVideo = dr["CodeValue"].ToString(); break;

                }
            
            }
        }
        
    }
}
