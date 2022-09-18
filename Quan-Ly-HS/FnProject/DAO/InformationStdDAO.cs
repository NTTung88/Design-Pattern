using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FnProject.DAO
{
    class InformationStdDAO
    {
        private static InformationStdDAO instance;

        public static InformationStdDAO Instance
        {
            get { if (instance == null) instance = new InformationStdDAO(); return InformationStdDAO.instance; }
            private set { InformationStdDAO.instance = value; }
        }
        private InformationStdDAO() { }

        public DataTable Update(string mssv, string placeOfBirth, string townOfOrigin,
            string gender, string nationality, string provinceOrCity, string dicstrict,
            string wardOrTown, string street, string addressNumber, string studentPhone,
            string idCardNumber, string dateIdCard, string placeIdCard)
        {
            string query = "UPDATE InStudent SET PlaceOfBirth='" + @placeOfBirth + "',TownOfOrigin='" + @townOfOrigin + "',Gender='" + @gender + "', Nationality ='" + @nationality + "', ProvinceOrCity ='" + @provinceOrCity +
                "',Dicstrict ='" + @dicstrict + "',WardOrTown='" + @wardOrTown + "',Street='" + @street + "',AddressNumber='" + @addressNumber + "', StudentPhone ='" + @studentPhone + "', IdCardNumber ='" + @idCardNumber +
                "',DateIdCard ='" + @dateIdCard + "' ,PlaceIdCard ='" + @placeIdCard + "' WHERE Mssv='" + @mssv + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] {  mssv ,  placeOfBirth, townOfOrigin,gender, nationality, provinceOrCity , dicstrict,wardOrTown, street,  addressNumber, studentPhone,idCardNumber, dateIdCard, placeIdCard });
            return table;
        }
        public DataTable GetInformationStudent(string mssv)
        {
            string query = "select * from InStudent where Mssv = '" + @mssv + "'";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { mssv });
        }

        public DataTable GetClassFromStudent(string mssv)
        {
            string query = "select * from Student as s ,Class as c where c.ClassId = s.ClassId and s.Mssv ='"+ @mssv+"'";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { mssv });
        }
    }
}
