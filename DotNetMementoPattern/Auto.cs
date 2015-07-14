using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetMementoPattern
{
    public class Auto
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public IMemento GetToMemento()
        {
            return new AutoMemento() { State = Price };
        }

        public void SetMemento(IMemento memento)
        {
            this.Price = (decimal)memento.State;
        }


        public class AutoMemento : IMemento
        {
            public object State
            {
                get;
                set;
            }
        }

    }

}