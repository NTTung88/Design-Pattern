using System;
using System.Collections.Generic;
using System.Text;

namespace FnProject.DAO
{
    class ShowList:ListFactory
    {
        public override IByList Show(ListType type)
        {
            switch (type)
            {
                case ListType.LISTCLASS:
                    return new GetListClass();
                case ListType.LISTSTUDENT:
                    return new GetListStudent();
                default:
                    throw new NotImplementedException();
            }   
            
            
        }
    }
}
