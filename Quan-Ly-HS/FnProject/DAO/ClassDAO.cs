using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FnProject.DAO
{
    class ClassDAO
    {
        private static ClassDAO instance;

        public static ClassDAO Instance
        {
            get { if (instance == null) instance = new ClassDAO(); return instance; }
            private set { instance = value; }
        }

        private ClassDAO() { }

        public DataTable GetListStudentByClass()
        {
            var factory = new ShowList();
            IByList list = factory.Show(ListType.LISTCLASS);  
            return list.GetListStudentClass();
        }

        public void InsertClass(string className, string classId)
        {
            string query = "Insert into Class(ClassId,ClassName) values('" + className + "','" + @classId + "')";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { className, classId });
        }
        public void DeleteClass(string classId)
        {
            //string query = "Delete from Class WHERE ClassId ='" + classId + "'";
            //DataProvider.Instance.ExecuteNonQuery(query, new object[] { classId });
            IComponent dlt = new Component();
            DecoratorClass dl = new DecoratorClass(dlt);
            dl.Delete(classId);
            
        }
        public bool CheckClassId(string classId)
        {
            string query = "SELECT ClassId from Class WHERE ClassId ='" + @classId + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { classId });
            return result.Rows.Count > 0;
        }
        public void UpdateClass(string classId, string className)
        {
            string query = "UPDATE Class SET ClassName='" + className + "' WHERE ClassId='" + classId + "'";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { className,  classId });
        }
        public DataTable SearchClass(string search)
        {
            string query = "SELECT * FROM Class WHERE ClassName='" + search + "' OR ClassId='" + search + "'";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { search, search });
        }
        public int CountClassId() 
        {
            string query = "SELECT COUNT(ClassId) FROM Class ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            Console.WriteLine(result);
            return result;
        }
        public bool CheckClassID(string classId)
        {
            //string query = "SELECT ClassId from Class WHERE ClassId ='" + classId + "'";
            //DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { classId });
            IFunctions checkid = new Adapter();
            return checkid.CheckClassID(classId); ;
        }


    }
}
