using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_01_TemplateMethod
{
    public class BeverageTestDrive
    {
        public static void Main(string[] args)
        {

            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            Console.WriteLine("\nMaking tea...");
            tea.prepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffee.prepareRecipe();


            TeaWithHook teaHook = new TeaWithHook();
            CoffeeWithHook coffeeHook = new CoffeeWithHook();

             Console.WriteLine("\nMaking tea...");
            teaHook.prepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffeeHook.prepareRecipe();

        }
    }

}
