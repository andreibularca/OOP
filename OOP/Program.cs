using OOP.Abstraction;
using OOP.Encapsulation;
using OOP.Inheritance;
using OOP.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ENCAPSULATION

            var employee = new Employee();
            employee.SetName("John");
            employee.SetAge(23);

            Console.WriteLine("Employee id: {0}", employee.Id);
            Console.WriteLine("Employee name: {0}", employee.GetName());
            Console.WriteLine("Employee age: {0}", employee.GetAge());

            #endregion

            #region ABSTRACTION

            //Console.WriteLine("========== ABSTRACTION ==========");
            //Console.WriteLine();

            //List<Vegetable> vegetables = new List<Vegetable>();
            //vegetables.Add(new Tomato());
            //vegetables.Add(new Cabbage());

            //float LandTemp = 35;
            //float AirHumidity = 36;
            //float LandHumitity = 40;

            //foreach (Vegetable item in vegetables)
            //{
            //    Console.WriteLine("=====================================");
            //    Console.WriteLine("Vegetable name: {0}", item.GetVegetableName());

            //    if (item.DoINeedIrrigationNow(LandTemp, AirHumidity, LandHumitity))
            //    {
            //        item.IrrigateMe();
            //    }
            //    else
            //    {
            //        Console.WriteLine("No irrigation nedded for {0} !", item.GetVegetableName());
            //    }

            //    Console.WriteLine("=====================================");
            //    Console.WriteLine();
            //}

            #endregion

            #region INHERITANCE

            //Console.WriteLine("========== INHERITANCE ==========");

            //A aVar = new A();
            //aVar.AMethod();
            //aVar.BMethod();
            //aVar.CMethod();

            //Console.WriteLine();

            //C cVar = new A();
            //cVar.CMethod();
            //cVar = new B();
            //cVar.CMethod();

            //Console.WriteLine();

            #endregion

            #region POLYMORPHISM 

            //bool bExit = true;
            //var rectangle = new Rectangle();
            //var romb = new Rhombus();
            //var sqruare = new Square();

            //while (bExit)
            //{
            //    var bs = new CBaseShape();

            //    Console.WriteLine(@"Type your choice or type '0' to exit");
            //    Console.WriteLine(@"Select shape to paint: 1 - rhombus, 2 - square, 3 - rectangle");

            //    string line = Console.ReadLine();
            //    if (line == "0") 
            //    {
            //        break;
            //    }
            //    switch (line)
            //    {
            //        case "1":
            //            bs = romb;
            //            break;
            //        case "2":
            //            bs = sqruare;
            //            break;
            //        case "3":
            //            bs = rectangle;
            //            break;
            //        default:
            //            break;
            //    }
            //    bs.PaintMyself();
            //}

            #endregion

        }
    }
}
