using System;

namespace Laboratorio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string GenC = Console.ReadLine();
            string ArtC = Console.ReadLine();
            string AlbC = Console.ReadLine();
            string NomC = Console.ReadLine();
            Cancion C1 = new Cancion(GenC,ArtC,AlbC,NomC);

            Espotifai EspPrueba = new Espotifai();
            EspPrueba.AgregarCancion(C1);

            EspPrueba.VerCanciones();
        }

    }   
}
