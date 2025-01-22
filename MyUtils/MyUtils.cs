using Microsoft.Win32.SafeHandles;
using System.Reflection.Metadata.Ecma335;
namespace MyUtils
{
    public class Utils
    {
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
        public static double ComprovarNum()
        {
            const string MsgError = "El valor no és un número!";
            double result;
            string? num = Console.ReadLine();
            try
            {
                result = Convert.ToDouble(num);
            }
            catch (FormatException)
            {
                Console.WriteLine(MsgError);
                result = ComprovarNum();
            }
            return result;
        }
        public static int ComprovarNum(int num2, int compara) 
        {
            const string Msg = "El format no es correcte",
            MsgError = "El valor no és un número!";
            string? num = Console.ReadLine();
            int result;
            if (!ComprovarNum(num))
            {
                Console.WriteLine(MsgError);
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
        public static void Menu()
        {
            const string CapMenu = "\t\tEscull una opció",
                MenuOpcions = "\t\t1. Iniciar simulacions \n\t\t2. Veure informe de simulacions\n\t\t3. Sortir",
                MenuSep = "\t\t************************************";
            Console.WriteLine(CapMenu);
            Console.WriteLine(MenuSep);
            Console.WriteLine(MenuOpcions);
        }
        public static int OpcioMenu()
        {
            const string Msg = "Aqueta opció no es valida!";
            string? opcio = Console.ReadLine();
            int result;
            while (opcio != "1" && opcio != "2" && opcio != "3")
            {
                Console.WriteLine(Msg);
                opcio = Console.ReadLine();
            }
            result = Convert.ToInt32(opcio);
            return result;
        }
        public static int IniciarSimulacio()
        {
            const string MsgTipus = "Indica el tipus d'energia (solar, eolica, hidroelectrica)",
            MsgError = "El valor es incorrecte";
            string? tipus;
            Console.WriteLine(MsgTipus);
            tipus = Console.ReadLine().ToUpper();
            while (tipus != "EOLICA" && tipus != "HIDROELECTRICA" && tipus != "SOLAR")
            {
                Console.WriteLine(MsgError);
                tipus = Console.ReadLine().ToUpper();
            }
            
            if (tipus == "EOLICA") { return 1; } else if (tipus == "HIDROELECTRICA") { return 2; } else { return 3; }
        }
    }
}
