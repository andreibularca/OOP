using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public class Square : CBaseShape
    {
        public override void PaintMyself()
        {
            Console.WriteLine("  ****");
            Console.WriteLine("  ****");
            Console.WriteLine("  ****");
            Console.WriteLine("  ****");
        }
    }
}
