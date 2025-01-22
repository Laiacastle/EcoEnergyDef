using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtils;

namespace EcoEnergyDef
{
    public abstract class SistemaEnergia: ICalculEnergia
    {
        protected DateTime Date { get; set; }
        protected string? Type { get; set; }


        public virtual bool ConfParametre() { return true; }
        public virtual double CalcEnergia() { return 0.0; }
        public virtual void MostraInforme() { }
        public virtual void MostraDades() { }

    }
}
