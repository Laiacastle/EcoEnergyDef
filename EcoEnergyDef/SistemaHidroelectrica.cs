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
        public void MostraInforme() => Console.WriteLine($"data: {this.Date} tipus: {this.Type} cabal d'aigua: {this.CabalAigua}");
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
