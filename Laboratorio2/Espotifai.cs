using System;
using System.Collections.Generic;

namespace Laboratorio2
{
    public class Espotifai
    {
        public List<Cancion> Songs = new List<Cancion>();
        

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

        List<Cancion> SongsPC1 = new List<Cancion>();
        public Cancion[] CPC(String Criterio, String Valor)
        {
            foreach (Cancion S in Songs)
            {
                if (S.Informacion().Contains(Criterio) == true && S.Informacion().Contains(Valor) == true)
                {
                    SongsPC1.Add(S);
                }
            }

            Cancion[] SongsPC2 = new Cancion[SongsPC1.Count];
            int Cont = 0;
            foreach (Cancion SONG in SongsPC1)
            {
                SongsPC2[Cont] = SONG;
            }
            
            return SongsPC2;


            
        }
    }
}
