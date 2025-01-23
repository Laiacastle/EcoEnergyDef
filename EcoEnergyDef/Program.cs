using MyUtils;
using System;
namespace EcoEnergyDef
{
    public class Program
    {
        public static void Main() {
            bool menu = true;

            const string Title = "\t\t\t·········································································\r\n\t\t\t:▓█████.▄████▄..▒█████.....▓█████.███▄....█▓█████.██▀███...▄███▓██...██▓:\r\n\t\t\t:▓█...▀▒██▀.▀█.▒██▒..██▒...▓█...▀.██.▀█...█▓█...▀▓██.▒.██▒██▒.▀█▒██..██▒:\r\n\t\t\t:▒███..▒▓█....▄▒██░..██▒...▒███..▓██..▀█.██▒███..▓██.░▄█.▒██░▄▄▄░▒██.██░:\r\n\t\t\t:▒▓█..▄▒▓▓▄.▄██▒██...██░...▒▓█..▄▓██▒..▐▌██▒▓█..▄▒██▀▀█▄.░▓█..██▓░.▐██▓░:\r\n\t\t\t:░▒████▒.▓███▀.░.████▓▒░...░▒████▒██░...▓██░▒████░██▓.▒██░▒▓███▀▒░.██▒▓░:\r\n\t\t\t:░░.▒░.░.░▒.▒..░.▒░▒░▒░....░░.▒░.░.▒░...▒.▒░░.▒░.░.▒▓.░▒▓░░▒...▒..██▒▒▒.:\r\n\t\t\t:.░.░..░.░..▒....░.▒.▒░.....░.░..░.░░...░.▒░░.░..░.░▒.░.▒░.░...░▓██.░▒░.:\r\n\t\t\t:...░..░.......░.░.░.▒........░.....░...░.░...░....░░...░░.░...░▒.▒.░░..:\r\n\t\t\t:...░..░.░.........░.░........░..░........░...░..░..░..........░░.░.....:\r\n\t\t\t:......░........................................................░.░.....:\r\n\t\t\t·········································································\n",
                MsgVegades = "\t\t\t\tIndica les simulacions que vols fer (máxim total: 99) ",
                MsgVal = "\t\t\t\tIndica el valor de: {0}",
                MsgErrorTipus = "\t\t\t\tEl valor es incorrecte, ",
                MsgErrorSol = "el numero no pot ser menor de 1",
                MsgErrorEol = "el numero no pot ser menor a 5",
                MsgErrorHidro = "el numero no pot ser menor de 20",
                MsgTipSol = "hores de sol",
                MsgInput = "\t\t>",
                Red = "red",
                MsgTipHid = "cabal d'aigua",
                MsgTipEo = "velocitat de vent",
                MsgResult = "\t\t\t\tEl resultat es: {0}",
                MsgNull = "\t\t\t\tNo hi ha simulacions fetes!",
                MsgErrorNoEspai = "\t\t\t\tJa no hi ha espai disponible!",
                MsgCapçelera = "\t\t----------------------------------------------------------------------------\n\t\t|        Data         |      Tipus      |       Dada        |    Resultat  |\n\t\t----------------------------------------------------------------------------",
                MsgFinal = "\t\t\t\t___________.__                            .__        __  ._.\r\n\t\t\t\\_   _____/|__| ____   ______ _____ ___  _|__|____ _/  |_| |\r\n |    __)  |  |/    \\ /  ___/ \\__  \\\\  \\/ /  \\__  \\\\   __\\ |\r\n |     \\   |  |   |  \\\\___ \\   / __ \\\\   /|  |/ __ \\|  |  \\|\r\n \\___  /   |__|___|  /____  > (____  /\\_/ |__(____  /__|  __\r\n     \\/            \\/     \\/       \\/             \\/      \\/";


            enum Color Red = Color.Red;
        //creem l'array que guardará totes les instancies
        SistemaEnergia[] objectes = new SistemaEnergia[99];
            Utils.CambiarColor(Title, Red);
            while (menu)
            {
                //printem el menu
                Utils.Menu();
                switch (Utils.OpcioMenu())
                {
                    //iniciar simulacions
                    case 1:
                        if (objectes[98] == null)
                        {
                            //Preguntem cuantes vegades vol fer simulacions
                            Console.WriteLine(MsgVegades);
                            int vegades = Utils.ComprovarNum(0, 1);

                            SistemaEnergia[] objecte = new SistemaEnergia[vegades];

                            for (int i = 0; i < vegades; i++)
                            {
                                //creem nous objectes
                                switch (Utils.IniciarSimulacio())
                                {
                                    //objecte sistema eolica
                                    case 1:
                                        Console.WriteLine(MsgVal, MsgTipEo);

                                        //comprova el valor i crea l'objecte
                                        double valEo = Utils.ComprovarNum();
                                        SistemaEolica sisEo = new SistemaEolica(valEo);
                                        while (!sisEo.ConfParametre())
                                        {
                                            Utils.CambiarColor(MsgErrorTipus + MsgErrorEol, Red);
                                            Console.Write(MsgInput);
                                            valEo = Utils.ComprovarNum();
                                            sisEo = new SistemaEolica(valEo);
                                        }

                                        //printa el result
                                        Console.WriteLine(MsgResult, sisEo.CalcEnergia());

                                        //afegeix l'objecte a l'array
                                        objecte[i] = sisEo;

                                        ; break;

                                    case 2:
                                        //HIDROELECTRICA

                                        Console.WriteLine(MsgVal, MsgTipHid);

                                        //comprova el valor i crea l'objecte
                                        double valHidr = Utils.ComprovarNum();
                                        SistemaHidroelectrica sisHidr = new SistemaHidroelectrica(valHidr);
                                        while (!sisHidr.ConfParametre())
                                        {
                                            Utils.CambiarColor(MsgErrorTipus + MsgErrorHidro, Red);
                                            Console.Write(MsgInput);
                                            valHidr = Utils.ComprovarNum();
                                            sisHidr = new SistemaHidroelectrica(valHidr);
                                        }

                                        //printa el resultat
                                        Console.WriteLine(MsgResult, sisHidr.CalcEnergia());

                                        //afegeix l'objecte a l'array
                                        objecte[i] = sisHidr;

                                        ; break;

                                    case 3:
                                        //SOLAR

                                        Console.WriteLine(MsgVal, MsgTipSol);

                                        //comprova el valor i crea l'objecte
                                        double valSol = Utils.ComprovarNum();
                                        SistemaSolar sisSol = new SistemaSolar(valSol);
                                        while (!sisSol.ConfParametre())
                                        {
                                            Utils.CambiarColor(MsgErrorTipus + MsgErrorSol, Red);
                                            Console.Write(MsgInput);
                                            valSol = Utils.ComprovarNum();
                                            sisSol = new SistemaSolar(valSol);
                                        }

                                        //printa el result
                                        Console.WriteLine(MsgResult, sisSol.CalcEnergia());

                                        //afegeix l'objecte a l'array
                                        objecte[i] = sisSol;
                                        ; break;
                                }
                            }
                            //afegeix el nou array d'objectes a l'array base
                            int j = 0;
                            for (int i = 0; i < objectes.Length; i++)
                            {
                                while (objectes[i] == null && j < objecte.Length)
                                {
                                    objectes[i] = objecte[j];
                                    j++;
                                }
                            }
                        }
                        else
                        {
                            Utils.CambiarColor(MsgErrorNoEspai, Red);
                        }
                        ;break;
                    //Mostrar informe
                    case 2:
                        if (objectes[0] == null)
                        {
                            Utils.CambiarColor(MsgNull, Red);
                        }
                        else{
                            Console.WriteLine(MsgCapçelera);
                            for (int i = 0; objectes[i] != null; i++)
                            {
                                Console.WriteLine(objectes[i].ToString());
                            }
                        }
                        ; break;
                        //sortir del menu
                    case 3:
                        Utils.CambiarColor(MsgFinal, "green");
                        menu = false;break;
                }
                
            }
            
    } }
}