using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface ITrabajador
    {
        public void CobrarSueldo();

    }

    public interface IAFP
    {
        public void DescontarAFP();
        public void DescontarSeguroAFP();
        public void ComisionarAFP();
        
    }
    public interface IEmpleadoPanilla
    {
        public void Descontar5taCategoria();
    }

    public interface IEmpleadoSinPlanilla
    {
        public void Descontar4taCategoria();
    }
}
