﻿using System;
using System.Collections.Generic;

namespace Laboratorio2
{
    public class Playlist
    {
        private List<Cancion> PLfinal = new List<Cancion>();
        private string NombreP;
        List<Cancion> CancionesPL = new List<Cancion>();
        List<string> NombresPLayLists = new List<string>();

        public Playlist(string NP, List<Cancion> cancions)
        {
            NombreP = NP;
            PLfinal = cancions;
        }
        public string InfoNPL()
        {
            string NomPlay = ("El nombre de su PlayList es: " + NombreP);
            return NomPlay;
        }
        public string InfoCS()
        {
            string CanPlay = "";
            for (int X =0; X<PLfinal.Count;X++)
            {
                CanPlay += PLfinal[X].Informacion() + "\n";
            }
            return CanPlay;
        }

        



    }   
}
