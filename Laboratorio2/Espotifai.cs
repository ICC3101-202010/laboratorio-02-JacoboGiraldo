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
            for (int Num = 0; Num < Songs.Count; Num++)
            {
                if (Cont == Num)
                {
                    Cont++;
                }
                if (cancionX.Informacion() == Songs[Num].Informacion())
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
    }
}
