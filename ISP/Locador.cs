using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Locador : ITrabajador, IEmpleadoSinPlanilla
    {
        public void CobrarSueldo()
        {
            throw new NotImplementedException();
        }

        public void Descontar4taCategoria()
        {
            throw new NotImplementedException();
        }
    }
}
