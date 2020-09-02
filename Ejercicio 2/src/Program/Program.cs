using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            Biblioteca.AlmacenarLibro(libro1,"A","7");
            Biblioteca.AlmacenarLibro(libro2,"B","3");
            Console.WriteLine(libro1.EstanteBiblioteca);
            Console.WriteLine(libro2.SectorBiblioteca);
        }
    }
}
