using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergyDef
{
    public class SistemaHidroelectric : SistemaEnergia, ICalculEnergia
    {
        public double CabalAigua { get; set; }
        public double CalcEnergia() => this.CabalAigua * 9.8 * 0.8;
        public void MostraInforme() => Console.WriteLine($"\t\t------------------------------------------------------------------------\n\t\t|        Data        |      Tipus      |   Cabal d'aigua   | Instancia |\n\t\t------------------------------------------------------------------------\n\t\t| {this.Date.ToString()} | {this.Type}  |       {this.CabalAigua}          |     {this.Contador}     |\n\t\t------------------------------------------------------------------------");
        public bool ConfParametre() => this.CabalAigua >= 20.0;
        public SistemaHidroelectric(double cabalAigua)
        {
            Date = DateTime.Today;
            Type = "Hidroelectrica";
            CabalAigua = cabalAigua;
            Contador++;
        }
    }
}
