using System;

namespace Laboratorio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion("Trap", "Bad Bunny", "YHLQMDLG", "Safaera");
            Cancion cancion2 = new Cancion("Trap", "Rich Music LTD", "The Academy", "Perreo en la Luna");
            Cancion cancion3 = new Cancion("Trap", "Bad Bunny", "YHLQMDLG", "Safaera");
            

            Espotifai espotifai1 = new Espotifai();
            Espotifai espotifai2 = new Espotifai();
            Espotifai espotifai3 = new Espotifai();

            Console.WriteLine(espotifai1.AgregarCancion(cancion1));
            Console.WriteLine(espotifai2.AgregarCancion(cancion2));
            Console.WriteLine(espotifai3.AgregarCancion(cancion3));

            
        }

    }   
}
