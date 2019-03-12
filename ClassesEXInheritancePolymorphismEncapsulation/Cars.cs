using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismEncapsulationClasses
{
    public class Car
    {
        public void Race(Car winner)
        {

            Console.WriteLine("Yee Yee!");
        }
    }
    public class Nissan : Car
    {

    }
    public class Ford : Car
    {

    }
    public class Altima : Nissan
    {

    }
    public class Taurus : Ford
    {

    }
    public class Acura : Car
    {

    }
    public class TSX : Acura
    {
        public bool IsWinner { get; internal set; }
    }
}
