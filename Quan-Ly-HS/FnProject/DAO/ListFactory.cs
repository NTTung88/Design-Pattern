using System;
using System.Collections.Generic;
using System.Text;

namespace FnProject.DAO
{
    public abstract class ListFactory
    {
        public abstract IByList Show(ListType type);
    }
}
