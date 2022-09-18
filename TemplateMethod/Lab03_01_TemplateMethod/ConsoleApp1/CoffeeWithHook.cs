using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_01_TemplateMethod
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
        public override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool customerWantsCondiments()
        {

            String answer = getUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private String getUserInput()
        {
            string answer = null;
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");
            Console.OutputEncoding = Encoding.UTF8;
            string n = Convert.ToString(Console.ReadLine());
            try
            {
                answer = n;
            }
            catch (IOException)
            {
                Console.WriteLine("IO error trying to read your answer");
            }
            if (answer == null)
            {
                return "no";
            }
            return answer;
        }


    }

}
