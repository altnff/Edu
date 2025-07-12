using Calc.Lib;
using System.Drawing;
using Console = Colorful.Console;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool argAParsed = false;
            int argA = 0;
            bool argBParsed = false;
            int argB = 0;

            while (!argAParsed)
            {
                Console.WriteLine("Введите первый аргумент:");
                var inputA = Console.ReadLine();

                argAParsed = int.TryParse(inputA, out argA);
                
                if (!argAParsed)
                {
                    Console.WriteLine("Аргумент введен неверно.");
                }
            }

            while (!argBParsed)
            {
                Console.WriteLine("Введите второй аргумент:");
                var inputB = Console.ReadLine();

                argBParsed = int.TryParse(inputB, out argB);

                if (!argBParsed)
                {
                    Console.WriteLine("Аргумент введен неверно.");
                }
            }

            Console.WriteLine($"{CalcHelper.Add(argA, argB)}", Color.Red );
        }
    }
}
