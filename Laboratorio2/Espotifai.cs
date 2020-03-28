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
                    return false;
                }
                else 
                {
                    Songs.Add(cancionX);
                    return true;
                }
            }
            if (Cont==0)
            {
                Songs.Add(cancionX);
                return true;
            }
            else
            {
                return true;
            }

            

        }

        public void VerCanciones()
        {
            foreach (Cancion SongList in Songs)
            {
                Console.WriteLine(SongList.Informacion());
            }

        }
    }
}
