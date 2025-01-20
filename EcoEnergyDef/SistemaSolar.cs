using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergyDef
{
    public class SistemaSolar : SistemaEnergia, ICalculEnergia
    {
        private static int _contador = 0;
        public double HoresSol { get; set; }
        public double CalcEnergia() => this.HoresSol * 1.5;
        public void MostraInforme() => Console.WriteLine($"\t\t------------------------------------------------------------------------\n\t\t|        Data        |      Tipus      |    Hores de sol   | Instancia |\n\t\t------------------------------------------------------------------------\n\t\t| {this.Date.ToString()} |      {this.Type}      |       {this.HoresSol}          |     {_contador}     |\n\t\t------------------------------------------------------------------------");
        public bool ConfParametre() => this.HoresSol >= 1.0;
        public SistemaSolar(double horesSol)
        {
            Date = DateTime.Today;
            Type = "Solar";
            HoresSol = horesSol;
            _contador++;
        }
    }
}
