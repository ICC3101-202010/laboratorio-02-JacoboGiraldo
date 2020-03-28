using System;
using System.Collections.Generic;

namespace Laboratorio2
{
    public class Espotifai
    {
        public List<Cancion> SongsSpotify = new List<Cancion>();
        
        public Espotifai()
        {

        }

        public bool AgregarCancion(Cancion cancionX)
        {
            foreach (Cancion X in SongsSpotify)
            {
                if (cancionX.Informacion() == X.Informacion())
                {
                    return false;
                }
                else
                {
                    SongsSpotify.Add(cancionX);
                    return true;
                }
            }
            



        }

        public void VerCanciones()
        {
            Console.WriteLine(SongsSpotify);

        }
    }
}
