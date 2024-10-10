using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Aguila : IAnimal, IVolador
    {
        public void Comer()
        {
            throw new NotImplementedException();
        }

        public void Volar()
        {
            throw new NotImplementedException();
        }
    }
}
