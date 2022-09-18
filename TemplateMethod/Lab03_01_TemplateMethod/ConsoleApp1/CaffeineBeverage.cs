using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_01_TemplateMethod
{
    public abstract class CaffeineBeverage
    {

        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }

        public abstract void brew();

        public abstract void addCondiments();

        void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}

