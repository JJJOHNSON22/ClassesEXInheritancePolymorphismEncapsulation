using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismEncapsulationClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Altima becka = new Altima();
            TSX jerome = new TSX();
            Taurus jake = new Taurus();
            jerome.Race(jake);
            jerome.Race(new Altima());
            jerome.IsWinner = true;
            if(jerome.IsWinner)
            {
                Console.WriteLine("Winner winner chicken dinner!");
            }
            else
            {
                Console.WriteLine("I'll get 'em next time...");
            }
            Console.ReadLine();
        }
    }
}
