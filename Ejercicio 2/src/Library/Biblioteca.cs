using System;

namespace SRP
{
    public class Biblioteca
    {
        public static void AlmacenarLibro(Libro libro, String sector, String estante)
        {
            libro.SectorBiblioteca = sector;
            libro.EstanteBiblioteca = estante;

        }
    }
}