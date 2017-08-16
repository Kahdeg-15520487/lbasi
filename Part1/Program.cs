using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("calc> ");
                var text = Console.ReadLine();
                Interpreter interpreter = new Interpreter(text);
                var result = interpreter.expr();
                Console.WriteLine(result);
            }
        }
    }
}
