using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetMementoPattern
{
    //caretaker class in this case
    class Program
    {
      
        static void Main(string[] args)
        {
            const decimal NewCarPrice = 30000.00m;

           var _mementos = new List<IMemento>();
           var auto = new Auto() { Year = 1999, Price = 50000, Brand = "Focus" };
            //save value of price
           _mementos.Add(auto.GetToMemento());
           Console.WriteLine("{0} Year : {1} Price: {2:C2}", auto.Brand, auto.Year, auto.Price);
           Console.WriteLine("Change price to {0:C2}",NewCarPrice);
           auto.Price = NewCarPrice;
           Console.WriteLine("recovery value for memento");
           auto.SetMemento(_mementos[0]);
           Console.WriteLine("value recover from {0:C2} to {1:C2}", NewCarPrice ,auto.Price);
           Console.ReadLine();




        }
    }
}
