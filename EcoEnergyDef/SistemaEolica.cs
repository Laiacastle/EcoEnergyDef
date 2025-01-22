using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergyDef
{
    public class SistemaEolica : SistemaEnergia
    {
        private static int _contador = 0;
        public double VelocitatVent { get; set; }
        public override double CalcEnergia() => Math.Round(Math.Pow(this.VelocitatVent, 3) * 0.2);
        public override void MostraInforme() => Console.WriteLine($"\t\t-------------------------------------------------------------------------\n\t\t|        Data         |      Tipus      | Velocitat de vent | Instancia | \n\t\t-------------------------------------------------------------------------\n\t\t| {this.Date.ToString()} |     {this.Type}      |       {this.VelocitatVent}          |     {CalcEnergia()}     |\n\t\t-------------------------------------------------------------------------");
        public override void MostraDades() => Console.WriteLine($"\t\t-------------------------------------------------------------------------\n\t\t| {this.Date.ToString()} |      {this.Type}      |       {this.VelocitatVent}          |     {CalcEnergia()}     |\n\t\t-------------------------------------------------------------------------");
        public override bool ConfParametre() => this.VelocitatVent >= 5.0;

        public SistemaEolica(double velocitatVent)
        {
            Date = DateTime.Now;
            Type = "Eolica";
            VelocitatVent = velocitatVent;
            _contador++;
        }
        public SistemaEolica(double velocitatVent, DateTime data)
        {
            Date = data;
            Type = "Eolica";
            VelocitatVent = velocitatVent;
            _contador++;
        }

    }
}
