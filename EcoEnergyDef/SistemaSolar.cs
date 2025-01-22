using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergyDef
{
    public class SistemaSolar : SistemaEnergia
    {
        private static int _contador = 0;
        public double HoresSol { get; set; }
        public override double CalcEnergia() => Math.Round(this.HoresSol * 1.5);
        public override void MostraInforme() => Console.WriteLine($"\t\t-------------------------------------------------------------------------\n\t\t|        Data         |      Tipus      |    Hores de sol   | Instancia | \n\t\t-------------------------------------------------------------------------\n\t\t| {this.Date.ToString()} |      {this.Type}      |       {this.HoresSol}          |     {CalcEnergia()}     |\n\t\t-------------------------------------------------------------------------");
        public override void MostraDades() => Console.WriteLine($"\t\t-------------------------------------------------------------------------\n\t\t| {this.Date.ToString()} |      {this.Type}      |       {this.HoresSol}          |     {CalcEnergia()}     |\n\t\t-------------------------------------------------------------------------");
        public override bool ConfParametre() => this.HoresSol >= 1.0;
        public SistemaSolar(double horesSol)
        {
            Date = DateTime.Now;
            Type = "Solar";
            HoresSol = horesSol;
            _contador++;
        }
        public SistemaSolar(double horesSol, DateTime data)
        {
            Date = data;
            Type = "Solar";
            HoresSol = horesSol;
            _contador++;
        }
    }
}
