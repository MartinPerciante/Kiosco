using System;
//La clase libro no cumple con el patros SRP porque tiene tanto la responsabilidad de crear los libros
//como de almacenarlos. Lo que deberia hacerse es que AlmacenarLibro sea parte de otra clase de nombre Biblioteca que reciba al objeto, el estante y el sector.
//No cumple EXPERT porque la clase conoce mas de lo que respecta solamente a los libros
namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
    }
}
