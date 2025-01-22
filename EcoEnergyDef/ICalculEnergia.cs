using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergyDef
{
    public interface ICalculEnergia
    {
        bool ConfParametre();
        double CalcEnergia();
        void MostraInforme();

    }
}
