using System;
using System.Collections.Generic;

namespace Laboratorio2
{
    public class Espotifai
    {
        List<Cancion> Songs = new List<Cancion>();
        List<Playlist> PLAYLIST = new List<Playlist>();

        public Espotifai()
        {
        }
        public bool AgregarCancion(Cancion cancionX)
        {
            int Cont = 0;
            for (int i = 0; i < Songs.Count; i++)
            {
                if (Cont == i)
                {
                    Cont++;
                }
                if (cancionX.Informacion() == Songs[i].Informacion())
                {
                    Console.WriteLine("La cancion ya existe");
                    return false;
                }
                else 
                {
                    Songs.Add(cancionX);
                    Console.WriteLine("La cancion se agrego exitosamente");
                    return true;
                }
            }
            if (Cont==0)
            {
                Songs.Add(cancionX);
                Console.WriteLine("La cancion se agrego exitosamente");
                return true;
            }
            else
            {
                return false;
            }
        }
        public void VerCanciones()
        {
            if (Songs.Count == 0)
            {
                Console.WriteLine("Aun no hay canciones agregadas");
            }
            foreach (Cancion SongOfList in Songs)
            {
                Console.WriteLine(SongOfList.Informacion());
            }
        }       
        public List<Cancion> CPC(String Criterio, String Valor)
        {
            List<Cancion> SongsPC1 = new List<Cancion>();
            int Contador = 0;
            foreach (Cancion S in Songs)
            {
                if (S.Informacion().Contains(Criterio) == true && S.Informacion().Contains(Valor) == true)
                {
                    SongsPC1.Add(S);
                    Contador += 1;
                } 
            }
            if (Contador == 0)
            {
                Console.WriteLine("Sus criterios de busqueda no coinciden con ninguna cancion");
            }
            return SongsPC1;            
        }
        List<Cancion> Canciones = new List<Cancion>();
        List<string> NombresPlayLists = new List<string>();       
        public bool GenerarPlaylist(String C, String VC, String Nombre)
        {
            List<Cancion> CancionesPL = CPC(C,VC);

            if (Songs.Count == 0)
            {
                Console.WriteLine("No hay canciones existentes para agregar a su playlist");
                return false;
            }
            else if (CancionesPL.Count == 0)
            {
                Console.WriteLine("No hay canciones que cumplan con el criterio para generar la playlist");
                return false;
            }
            int Contador = 0;
            if (NombresPlayLists.Count == 0)
            {
                NombresPlayLists.Add(Nombre);
                foreach (Cancion Y in CancionesPL)
                {
                    if (Y.Informacion().Contains(C) && Y.Informacion().Contains(VC))
                    {
                        Canciones.Add(Y);
                    }
                }
                Console.WriteLine("Su Playlist ha sido creada exitosamente");
                PLAYLIST.Add(new Playlist(Nombre, CancionesPL));
                return true;
            }
            else if(NombresPlayLists.Count!=0)
            { 
                foreach (string NOM in NombresPlayLists)
                if (NOM == Nombre)
                {
                    Console.WriteLine("La playlist ya existe, intente de nuevo");
                    CancionesPL.Clear();
                    return false;
                }
                else if (NOM != Nombre)
                {
                    Contador += 1;
                }
            }  
            if (Contador != 0)
            {
                NombresPlayLists.Add(Nombre);
                foreach (Cancion Y in CancionesPL)
                {
                    if (Y.Informacion().Contains(C) && Y.Informacion().Contains(VC))
                    {
                        Canciones.Add(Y);
                    }
                }
                Console.WriteLine("Su Playlist ha sido creada exitosamente");
                PLAYLIST.Add(new Playlist(Nombre,CancionesPL));
                return true;
            }
            else
            {
                return false;
            }         
        }
        public String VerMisPlaylists()
        {
            string RES = "";
            if (PLAYLIST.Count == 0)
            {
                RES += "No hay ninguna playlist hasta el momento";                
            }
            else if (PLAYLIST.Count != 0)
            {
                foreach(Playlist playlist in PLAYLIST)
                {
                    RES += playlist.InfoNPL()+playlist.InfoCS() ;              
                }
            }
            return RES;
        }
    }   
}
