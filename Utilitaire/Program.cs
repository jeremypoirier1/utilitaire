namespace Utilitaire
{
    internal class Program
    {
        public static int LireEntier(string p_question)
        {
            int nombre; // Contiendra le nombre
            for (; ; )
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(p_question);
                /***/
                if (Int32.TryParse(Console.ReadLine(), out nombre))
                    break;
                /***/
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*** Veuillez entrer un simple entier.");
            }
            return nombre;
        }
        public static double LireReel(string p_question)
        {
            double nombre; // Contiendra le nombre
            for (; ; )
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(p_question);
                /***/
                if (double.TryParse(Console.ReadLine(), out nombre))
                    break;
                /***/
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*** Veuillez entrer un chiffre réel.");
            }
            return nombre;
        }
        public static char LireChar(string p_question)
        {
            char caractere; // Contiendra le caractère
            for (; ; )
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(p_question);
                /***/
                if (char.TryParse(Console.ReadLine(), out caractere))
                    break;
                /***/
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*** Veuillez entrer un caractère.");
            }
            return caractere;
        }
        public static string LireText(string p_question)
        {
            string text;
            for (; ; )
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(p_question);
                text = Console.ReadLine();
                break;
            }
            return text;
        }
        public static int LireEntierEntreIntervalles(string p_question, int min, int max)
        {
            int nombre; // Contiendra le nombre
            for (; ; )
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(p_question);
                /***/
                if (Int32.TryParse(Console.ReadLine(), out nombre))
                {
                    if (nombre >= min && nombre <= max)
                    {
                        break;
                    }
                }    /***/
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"*** Veuillez entrer un entier entre {min} et {max}.");
            }
            return nombre;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}