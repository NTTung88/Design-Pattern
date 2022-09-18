using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FnProject.DAO
{
    class Adapter : IFunctions
    {
        Function fn = new Function();

        public bool CheckClassID(string classId)
        {
            if (fn.CheckClassId(classId))
            {
                return true;
            }
            return false;
        }

        public bool CheckStdentId(string mssv)
        {
            if (!fn.CheckMssv(mssv))
            {
                return false;
            }
            return true;
        }
        public bool CheckClassIDFromStudent(string classId)
        {
            if (fn.CheckClassId(classId) == fn.CheckClassIdFromStudent(classId))
            {
                return true;
            }
            return false;
        }

    } 
}
