using System;
namespace Laboratorio2
{
    public class Cancion
    {
        private string Gen;
        private string Art;
        private string Alb;
        private string Nom;

        public Cancion(string gen, string art, string alb, string nom)
        {
            Gen = gen;
            Art = art;
            Alb = alb;
            Nom = nom;

        }

        public string Informacion()
        {
            string Inf = "genero: " + Gen + ", artista: " + Art + ", album: " + Alb + ",nombre: " + Nom;
            return Inf;
        }
    }
}
