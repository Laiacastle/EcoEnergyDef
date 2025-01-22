using MyUtils;
using System;
namespace EcoEnergyDef
{
    public class Program
    {
        public static void Main() {
            bool menu = true;
            const string MsgVegades = "Indica les simulacions que vols fer: ",
                MsgVal = "Indica el valor de: {0}",
                MsgErrorTipus = "El valor es incorrecte",
                MsgTipSol = "hores de sol",
                MsgTipHid = "cabal d'aigua",
                MsgTipEo = "velocitat de vent",
                CapInforme = "",
                MsgResult = "El resultat es: {0}",
                MsgNull = "No hi ha simulacions fetes!",
                MsgCapçelera = "\t\t-------------------------------------------------------------------------\n\t\t|        Data         |      Tipus      |   Dada   | Resultat |\n\t\t-------------------------------------------------------------------------";
           
            //creem l'array que guardará totes les instancies
            SistemaEnergia[] objectes = new SistemaEnergia[99];
            while (menu)
            {
                //printem el menu
                Utils.Menu();
                switch (Utils.OpcioMenu())
                {
                    //iniciar simulacions
                    case 1:
                        //Preguntem cuantes vegades vol fer simulacions
                        Console.WriteLine(MsgVegades);
                        int vegades = Utils.ComprovarNum(0, 1);

                        SistemaEnergia[] objecte = new SistemaEnergia[vegades];

                        for (int i = 0; i < vegades; i++)
                        {
                            //per cada vegada depen del tipus que l'usuari hagi escollit creem un nou objecte 
                            switch (Utils.IniciarSimulacio())
                            {
                                case 1:
                                    Console.WriteLine(MsgVal, MsgTipEo);
                                    double valEo = Utils.ComprovarNum();
                                    SistemaEolica sisEo = new SistemaEolica(valEo);
                                    while (!sisEo.ConfParametre())
                                    {
                                        Console.WriteLine(MsgErrorTipus);
                                        sisEo = new SistemaEolica(Convert.ToDouble(Console.ReadLine()));
                                    }
                                    Console.WriteLine(MsgResult, sisEo.CalcEnergia());
                                    objecte[i] = sisEo;
                                    ;break;
                                case 2:
                                    Console.WriteLine(MsgVal, MsgTipHid);
                                    double valHidr = Utils.ComprovarNum();
                                    SistemaHidroelectrica sisHidr = new SistemaHidroelectrica(valHidr);
                                    while (!sisHidr.ConfParametre())
                                    {
                                        Console.WriteLine(MsgErrorTipus);
                                        sisHidr = new SistemaHidroelectrica(Convert.ToDouble(Console.ReadLine()));
                                    }
                                    Console.WriteLine(MsgResult, sisHidr.CalcEnergia());
                                    objecte[i] = sisHidr;
                                    ;break;
                                case 3:
                                    Console.WriteLine(MsgVal, MsgTipSol);
                                    double valSol = Utils.ComprovarNum();
                                    SistemaSolar sisSol = new SistemaSolar(valSol);
                                    while (!sisSol.ConfParametre())
                                    {
                                        Console.WriteLine(MsgErrorTipus);
                                        sisSol = new SistemaSolar(Convert.ToDouble(Console.ReadLine()));
                                    }
                                    Console.WriteLine(MsgResult, sisSol.CalcEnergia());
                                    objecte[i] = sisSol;
                                    ;break;
                            }
                        }
                        int j = 0;
                        for (int i = 0; i < objectes.Length; i++)
                        {
                            while (objectes[i] == null && j<objecte.Length)
                            {
                                objectes[i] = objecte[j];
                                j++;
                            }
                        }
                        ;break;
                    //Mostrar informe
                    case 2:
                        Console.WriteLine(CapInforme);
                        if (objectes[0] == null)
                        {
                            Console.WriteLine(MsgNull);
                        }
                        else{
                            Console.WriteLine(MsgCapçelera);
                            for (int i = 0; objectes[i] != null; i++)
                            {
                                objectes[i].MostraDades();
                            }
                        }
                        ; break;
                        //sortir del menu
                    case 3: menu = false;break;
                }
                
            }
            
    } }
}