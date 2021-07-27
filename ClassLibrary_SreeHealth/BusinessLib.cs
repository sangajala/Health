using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_SreeHealth
{
    public class BusinessLib
    {
        DataLib dlib = new DataLib();
        #region LOAD
        public DataTable Load_T01()
        {
            return dlib.LoadData("Load_T01");
        }
        public DataTable Load_T01_Departments()
        {
            return dlib.LoadData("Load_T01_Departments");
        }
        public DataTable Load_T02()
        {
            return dlib.LoadData("Load_T02");
        }
        public DataTable Load_T02_Doctors()
        {
            return dlib.LoadData("Load_T02_Doctors");
        }
        public DataTable Load_T03()
        {
            return dlib.LoadData("Load_T03");
        }
        public DataTable Load_T03_Patients()
        {
            return dlib.LoadData("Load_T03_Patients");
        }
        public DataTable Load_T04()
        {
            return dlib.LoadData("Load_T04");
        }
        #endregion LOAD
        #region INSERT
        public void Insert_T01(PropertyLib plib)
        {
            dlib.Insert_T01("Insert_T01", plib);
        }
        public void Insert_T02(PropertyLib plib)
        {
            dlib.Insert_T02("Insert_T02", plib);
        }
        public void Insert_T03(PropertyLib plib)
        {
            dlib.Insert_T03("Insert_T03", plib);
        }
        public void Insert_T04(PropertyLib plib)
        {
            dlib.Insert_T04("Insert_T04", plib);
        }
        #endregion INSERT

    }
}
