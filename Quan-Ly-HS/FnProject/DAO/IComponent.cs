using System;
using System.Collections.Generic;
using System.Text;

namespace FnProject.DAO
{
    interface IComponent
    {
        void Delete(string classId);
    }

    class Component : IComponent
    {

        public void Delete(string classId)
        {
            throw new NotImplementedException();
        }
    }
    class DecoratorStudent : IComponent
    {
        private readonly IComponent _component;
        public DecoratorStudent(IComponent component)
        {
            _component = component;
        }

        public void Delete(string mssv)
        {
            string query = "Delete from Student WHERE Mssv ='" + mssv + "'";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv });
        }
        
    }
    class DecoratorClass : IComponent
    {
        private readonly IComponent _component;
        public DecoratorClass(IComponent component)
        {
            _component = component;
        }

        public void Delete(string classId)
        {
            string query = "Delete from Class WHERE ClassId ='" + classId + "'";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { classId });
        }

       
    }
}
