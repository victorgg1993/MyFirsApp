using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Interfaces
{
    // Interface segregation Principle
    public class Avion : IVehiculo, ICloneable
    {
        // bombilla => implement new interface = auto-generat
        public void Acelerar(int kmh)
        {
            throw new NotImplementedException();
        }

        public void Aterrizar()
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public void Despegar()
        {
            throw new NotImplementedException();
        }

        public void Frenar()
        {
            throw new NotImplementedException();
        }

        public void Girar(int angulos)
        {
            throw new NotImplementedException();
        }
    }
}
