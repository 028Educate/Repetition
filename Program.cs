using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition
{
    class Program
    {
        static int stomachSpace;

        static void Main(string[] args)
        {
            WhileLoop();
            DoWhileLoop();
            ForLoop();
            ForeachLoop();
        }

        private static void WhileLoop()
        {
            Console.WriteLine("While Loop\n------------------\n");
            stomachSpace = 100;

            while(stomachSpace > 0)
            {
                stomachSpace -= 10;
                Console.WriteLine("Nom Nom! Space left in belly: " + stomachSpace + "%");
            }

            Console.WriteLine("C Shark is stuffed!!");
        }

        private static void DoWhileLoop()
        {
            Console.WriteLine("\n\nDo While Loop\n------------------\n");
            stomachSpace = 100;

            do
            {
                stomachSpace -= 10;
                Console.WriteLine("Nom Nom! Space left in belly: " + stomachSpace + "%");
            }
            while (stomachSpace > 0);

            Console.WriteLine("C Shark is stuffed!!");
        }

        private static void ForLoop()
        {
            Console.WriteLine("\n\nFor Loop\n------------------\n");
            
            for(stomachSpace = 100; stomachSpace > 0; stomachSpace -= 10)
            {
                Console.WriteLine("Nom Nom!");
            }

            Console.WriteLine("C Shark is stuffed!!");
        }

        private static void ForeachLoop()
        {
            Console.WriteLine("\n\nForeach Loop\n------------------\n");

            string[] foodConsumed = { "Tuna", "Turtle", "Seal" };

            Console.WriteLine("Last hunt, C Shark ate the following: \n");

            foreach(string foodItem in foodConsumed)
            {
                Console.WriteLine(foodItem);
            }
        }
    }
}
