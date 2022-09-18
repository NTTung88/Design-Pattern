using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FnProject.DAO
{
    class Function
    {
        public bool CheckMssv(string mssv)
        {
            string query = "SELECT mssv from Student WHERE Mssv ='" + @mssv + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { mssv });
            return result.Rows.Count > 0;
        }
        public bool CheckClassId(string classId)
        {
            string query = "SELECT ClassId from Class WHERE ClassId ='" + @classId + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { classId });
            return result.Rows.Count > 0;
        }
        public bool CheckClassIdFromStudent(string classId)
        {
            string query = "SELECT ClassId from Student WHERE ClassId ='" + @classId + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { classId});
            return result.Rows.Count > 0;
        }

    }
}
