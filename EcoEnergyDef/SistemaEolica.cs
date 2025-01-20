using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergyDef
{
    public class SistemaEolica : SistemaEnergia, ICalculEnergia
    {
        public double VelocitatVent { get; set; }
        public double CalcEnergia() => Math.Pow(this.VelocitatVent, 3) * 0.2;
        public void MostraInforme() => Console.WriteLine($"data: {this.Date} tipus: {this.Type} Velocidad de vent: {this.VelocitatVent}");
        public bool ConfParametre() => this.VelocitatVent >= 5.0;

        public SistemaEolica(double velocitatVent)
        {
            Date = DateTime.Today;
            Type = "Eolica";
            VelocitatVent = velocitatVent;
            Contador++;
        }

    }
}
