using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FnProject.DTO
{
    class Class
    {
        public Class(string classId,string className)
        {
            this.ClassId = classId;
            this.ClassName = className;
        }
        public Class(DataRow row)
        {
            this.ClassId = row["classId"].ToString();
            this.ClassName = row["className"].ToString();
        }

        private string classId;
        public string ClassId
        {
            get { return classId; }
            set { classId = value; }
        }

        private string className;

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
    }
}
