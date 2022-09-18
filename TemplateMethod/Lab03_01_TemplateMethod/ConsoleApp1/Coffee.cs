using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_01_TemplateMethod
{
    public class Coffee : CaffeineBeverage
    {

        public override void brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
        public override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }


    }
}

