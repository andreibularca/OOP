using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public class CBaseShape
    {
        public virtual void PaintMyself()
        {
            Console.WriteLine("I'm default implementation and don't paint anything");
        }
    }
}
