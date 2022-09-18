using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FnProject.DAO
{
    class GetListClass:IByList
    {
        public DataTable GetListStudentClass()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM Class");
        }
    }
}
