using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_4
{
    class avion:Carro
    {
        public void aterrizar()
        {
            Console.WriteLine("avion aterrizado");
        }
        public void despegar()
        {
            Console.WriteLine("avion despegado");
        }
    }
}
