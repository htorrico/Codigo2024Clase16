using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class DependienteSenior : ITrabajador, IAFP, IEmpleadoPanilla
    {
        public void CobrarSueldo()
        {
            throw new NotImplementedException();
        }

        public void ComisionarAFP()
        {
            throw new NotImplementedException();
        }

        public void Descontar5taCategoria()
        {
            throw new NotImplementedException();
        }

        public void DescontarAFP()
        {
            throw new NotImplementedException();
        }

        public void DescontarSeguroAFP()
        {
            throw new NotImplementedException();
        }
    }
}
