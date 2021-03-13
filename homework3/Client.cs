using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Client
    { 
         static void Main(string []args)
        {
            Instruction instruction = new Instruction();
            Execution execution = new Execution();

            instruction.inputInstruction();

            Console.WriteLine( "The total area is: "+execution.execute());

            Console.ReadKey();

        }
    }

    class Instruction
    {
        public void inputInstruction()
        {
            Console.WriteLine("INSTRUCTION IS A TROOP OF NUMBERS ");
            Console.WriteLine("1---> TRIANGLE ");
            Console.WriteLine("2---> RECTANGLE ");
            Console.WriteLine("3---> SQUARE ");
            Console.WriteLine("INPUT THE INSRUCTION PLS:");

        }
    }

    class Execution
    {
        public int execute()
        {
            int result = 0;
            Factory fac = new Factory();
            string input = Console.ReadLine();
            List<char> instruction = new List<char>();
            instruction = input.ToList();

            foreach (char elem in instruction)
            {
                Shape shape=fac.packProcess(elem);
                if (shape.inspectShape())
                    result += shape.Area;
            }

            return result;
        }
        
    }
}
