using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FnProject.DAO
{
    public interface IFunctions
    {
        public bool CheckStdentId(string mssv);

        public bool CheckClassID(string classId);

        public bool CheckClassIDFromStudent(string classId);
    }
}
