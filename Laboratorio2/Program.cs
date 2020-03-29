using System;

namespace Laboratorio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string Bienvenida = "Bienvenido estimad@ usuario al nuevo Espotifai, porfavor elija la opcion que desee del menu de opciones ingresando el numero de esta.";
            string ViewS = " 1) Ver Todas las canciones";
            string AgregarS = " 2) Agregar nueva cancion";
            string OutPro = " 3) Salir del programa";
            string Criterio = " 4) Ver canciones por Criterio";
            string MENU = ViewS + "\n" + AgregarS + "\n" + OutPro +"\n" + Criterio;

            Console.WriteLine(Bienvenida);
            Espotifai SpotifyFinal = new Espotifai();

            while (true)
            {
                Console.WriteLine(MENU);
                string Seleccion = Console.ReadLine();
                
                if (Seleccion == "2")
                {
                    Console.WriteLine("A continuacion ingrese el genero, artista, album y nombre de su cancion");                
                    string GenC = Console.ReadLine();
                    string ArtC = Console.ReadLine();
                    string AlbC = Console.ReadLine();
                    string NomC = Console.ReadLine();
                    Cancion X = new Cancion(GenC, ArtC, AlbC, NomC);

                    SpotifyFinal.AgregarCancion(X);
                    
                }
                if (Seleccion == "1")
                {
                    SpotifyFinal.VerCanciones();
                }
                if (Seleccion == "3")
                {
                    Console.WriteLine("Ha salido del programa");
                    break;
                }
                if (Seleccion == "4")
                {
                    Console.WriteLine("Porfavor ingrese su criterio y valor de busqueda:");
                    string Cri = Console.ReadLine();
                    string Val = Console.ReadLine();
                    SpotifyFinal.CPC(Cri, Val);
                    Console.WriteLine("Las canciones satisfacen su busqueda son las siguientes: ");
                    foreach (Cancion Xsong in (SpotifyFinal.CPC(Cri, Val)))
                    {
                        Console.WriteLine(Xsong);
                    }

                }
            }

            




           
        }

    }   
}
