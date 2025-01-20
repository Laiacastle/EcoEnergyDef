using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergyDef
{
    public class SistemaSolar : SistemaEnergia, ICalculEnergia
    {
        public double HoresSol { get; set; }
        public double CalcEnergia() => this.HoresSol * 1.5;
        public void MostraInforme() => Console.WriteLine($"data: {this.Date} tipus: {this.Type} Velocidad de vent: {this.HoresSol}");
        public bool ConfParametre() => this.HoresSol >= 1.0;
        public SistemaSolar(double horesSol)
        {
            Date = DateTime.Today;
            Type = "Solar";
            HoresSol = horesSol;
        }
    }
}
