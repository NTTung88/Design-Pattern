using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace FnProject.DAO
{
    public class StudentDAO
    {
        private static StudentDAO instance;

        public static StudentDAO Instance
        {
            get { if (instance == null) instance = new StudentDAO(); return StudentDAO.instance; }
            private set { StudentDAO.instance = value; }
        }
        private StudentDAO() { }

        public void InsertStudent(string mssv, string lastName, string firstName, string classId,string yearOfIntake,string modeOfTraining,string dateOfBirth)
        {
            string query = "Insert into Student( mssv, lastName, firstName ,classId , yearOfIntake , modeOfTraining , dateOfBirth) values('" + @mssv +"','" + @lastName + "','" + @firstName + "','" + @classId + "','" + @yearOfIntake + "','" + @modeOfTraining + "','" + @dateOfBirth + "')";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] {  mssv, lastName, firstName, classId, yearOfIntake, modeOfTraining, dateOfBirth });
        }
        public void DeleteStudent(string mssv)
        {
            //string query = "Delete from Student WHERE Mssv ='"+mssv+"'";
            //DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv });
            IComponent dlt = new Component();
            DecoratorStudent dl = new DecoratorStudent(dlt);
            dl.Delete(mssv);
        }
        public bool CheckMssv(string mssv)
        {
            //string query = "SELECT mssv from ListStudent WHERE Mssv ='" + @mssv + "'";
            //DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { mssv });
            //return result.Rows.Count > 0;
            IFunctions checkid = new Adapter();
            return checkid.CheckStdentId(mssv); 
        }

        // Kiểm tra ClassId of Class and Student
        public bool CheckIdForSC(string classId)
        {

            IFunctions checkid = new Adapter();
            return checkid.CheckClassIDFromStudent(classId);
        }
        
        public void UpdateStudent(string mssv, string lastName, string firstName, string classId, string yearOfIntake, string modeOfTraining, string dateOfBirth)
        {
            string query = "UPDATE Student SET FirstName='" + @firstName + "',LastName='" + @lastName + "',ClassId='" + @classId + "', YearOfIntake ='" + @yearOfIntake + "', DateOfBirth ='" + @dateOfBirth + "',ModeOfTraining ='" + @modeOfTraining + "'  WHERE Mssv='" + @mssv+"'";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv, lastName, firstName, classId, yearOfIntake, modeOfTraining, dateOfBirth });
        }


        public DataTable GetListStudentByClass()
        {
            var factory = new ShowList();
            IByList list = factory.Show(ListType.LISTSTUDENT);
            return list.GetListStudentClass();
        }
        public DataTable GetStudentFromClass(string classId)
        {
            string query = "select ld.* from Class as c,Student as ld where c.ClassId = ld.ClassId AND ld.ClassId = '"+@classId +"'";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { classId });
        }
    }
}
