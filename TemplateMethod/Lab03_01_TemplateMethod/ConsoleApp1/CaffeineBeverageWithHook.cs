using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_01_TemplateMethod
{
    public abstract class CaffeineBeverageWithHook
    {

        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();


            if (customerWantsCondiments())
            {
                addCondiments();
            }
        }

        public abstract void brew();
        public abstract bool customerWantsCondiments();
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
