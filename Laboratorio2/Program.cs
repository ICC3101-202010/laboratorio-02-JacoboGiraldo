using System;

namespace Laboratorio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion("Trap", "Bad Bunny", "YHLQMDLG", "Safaera");
            Console.WriteLine(cancion1.Informacion());

        }
    }
}
