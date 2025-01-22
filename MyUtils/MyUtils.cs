using Microsoft.Win32.SafeHandles;
using System.Reflection.Metadata.Ecma335;
namespace MyUtils
{
    public class Utils
    {
        /// <summary>
        ///  Comprova que un string sigui un integer
        /// </summary>
        /// <param>string?</param>
        /// <returns>retorna boolea</returns>
        public static bool ComprovarNum(string? num)
        {
            int result;
            try
            {
                result = Convert.ToInt32(num);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /// <summary>
        ///  Comprova que un n'umero introduit per pantalla sigui double
        /// </summary>
        /// <param>No parametres</param>
        /// <returns>retorna double</returns>
        public static double ComprovarNum()
        {
            const string MsgError = "\t\t\t\tEl valor no és un número!";
            double result;
            Console.Write("\t\t> ");
            string? num = Console.ReadLine();
            try
            {
                result = Convert.ToDouble(num);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(MsgError);
                Console.ForegroundColor = ConsoleColor.White;
                result = ComprovarNum();
            }
            return result;
        }

        /// <summary>
        ///  Compara un n'umero introduit per teclat amb un altre
        /// </summary>
        /// <param>int i 1, 2 dep'en de la posici'o del m'es gran</param>
        /// <returns>retorna int</returns>
        public static int ComprovarNum(int num2, int compara) 
        {
            const string Msg = "\t\t\t\tEl format no es correcte";
            Console.Write("\t\t> ");
            string? num = Console.ReadLine();
            int result;
            if (!ComprovarNum(num))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(Msg);
                Console.ForegroundColor = ConsoleColor.White;
                result = ComprovarNum(num2, compara);
            }
            else
            {
                result = Convert.ToInt32(num);
            }
            
            switch (compara)
            {
                case 1:
                    while (result < num2 && result == 0) 
                    {
                        Console.WriteLine(Msg);
                        result = Convert.ToInt32(Console.ReadLine());
                    };break;
                case 2:
                    while (result > num2 && result == 0) 
                    {
                        Console.WriteLine(Msg);
                        result = Convert.ToInt32(Console.ReadLine());
                    }; break;
            }
            return result;
            
        }

        /// <summary>
        ///  Printe el menu
        /// </summary>
        /// <param>No parametres</param>
        /// <returns>no retorna res</returns>
        public static void Menu()
        {
            const string CapMenu = "\n\n\t\t\t  ______     _                                                _     \r\n\t\t\t /_  __/____(_)___ _   __  ______  ____ _   ____  ____  _____(_)___ \r\n\t\t\t  / / / ___/ / __ `/  / / / / __ \\/ __ `/  / __ \\/ __ \\/ ___/ / __ \\\r\n\t\t\t / / / /  / / /_/ /  / /_/ / / / / /_/ /  / /_/ / /_/ / /__/ / /_/ /\r\n\t\t\t/_/ /_/  /_/\\__,_/   \\__,_/_/ /_/\\__,_/   \\____/ .___/\\___/_/\\____/ \r\n\t\t\t                                              /_/                   ",
                MenuOpcions = "\t\t\t\t1. Iniciar simulacions \n\t\t\t\t2. Veure informe de simulacions\n\t\t\t\t3. Sortir",
                MenuSep = "\t\t\t\t************************************";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(CapMenu);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(MenuSep);
            Console.WriteLine(MenuOpcions);
        }
        /// <summary>
        ///  Comprova que un numero sigui 1, 2, 3
        /// </summary>
        /// <param>No parametres</param>
        /// <returns>retorna integer</returns>
        public static int OpcioMenu()
        {
            const string Msg = "\t\t\t\tAquesta opció no es valida!";
            Console.Write("\t\t> ");
            string? opcio = Console.ReadLine();
            int result;
            while (opcio != "1" && opcio != "2" && opcio != "3")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(Msg);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t\t> ");
                opcio = Console.ReadLine();
            }
            result = Convert.ToInt32(opcio);
            return result;
        }

        /// <summary>
        ///  Comprova que un valor introduit per teclat sigui "eolica", "hidroelectrica" o "solar"
        /// </summary>
        /// <param>No parametres</param>
        /// <returns>retorna integer(1 = eolica/2 = hidoelectrica/3 = solar)</returns>
        public static int IniciarSimulacio()
        {
            const string MsgTipus = "\t\t\t\tIndica el tipus d'energia (solar, eolica, hidroelectrica)",
            MsgError = "\t\t\t\tEl valor es incorrecte";
            string? tipus;
            Console.WriteLine(MsgTipus);
            Console.Write("\t\t> ");
            tipus = Console.ReadLine().ToUpper();
            while (tipus != "EOLICA" && tipus != "HIDROELECTRICA" && tipus != "SOLAR")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(MsgError);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t\t> ");
                tipus = Console.ReadLine().ToUpper();
            }
            
            if (tipus == "EOLICA") { return 1; } else if (tipus == "HIDROELECTRICA") { return 2; } else { return 3; }
        }
    }
}
