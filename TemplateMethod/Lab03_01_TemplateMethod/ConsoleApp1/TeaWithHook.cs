
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_01_TemplateMethod
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
        public override void brew()
        {
            Console.WriteLine("Steeping the tea");
        }
        public override void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
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



        private  string getUserInput()
        {
            // get the user's response
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
