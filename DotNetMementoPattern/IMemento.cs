using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetMementoPattern
{
   public interface IMemento
    {
       object State { get; set; }
    }
}
