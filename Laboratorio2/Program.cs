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
            string CrearPL = " 5) Crear Playlist";
            string VerPL = " 6) Ver mis Playlists";
            string MENU = ViewS + "\n" + AgregarS + "\n" + OutPro +"\n" + Criterio + "\n" + CrearPL + "\n"+ VerPL;

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

                    Console.WriteLine("El resultado de su busqueda fue el siguiente ");
                    var Resul = SpotifyFinal.CPC(Cri, Val);
                    for (int i = 0; i < Resul.Count; i++)
                    {
                        Console.WriteLine(Resul[i].Informacion());
                    }

                }
                if (Seleccion == "5")
                {
                    
                    Console.WriteLine("Porfavor ingrese el nombre de su playlist junto con el criterio y valor de las canciones que quiere dentro de esta");
                    string NP1 = Console.ReadLine();
                    string C1 = Console.ReadLine();
                    string CV1 = Console.ReadLine();
                    
                    SpotifyFinal.GenerarPlaylist(C1, CV1, NP1);
                    
                }
                if (Seleccion == "6")
                {
                    Console.WriteLine("Sus playlists son las siguientes: ");
                    Console.WriteLine(SpotifyFinal.VerMisPlaylists());
                }

            }   

            




           
        }

    }   
}
