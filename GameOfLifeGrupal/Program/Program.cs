using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Reglas.Logica(LectorArchivo.TableroInicial("..\\glider.txt"));
            Printer.Imprimir("..\\glider.txt");
        }
    }
}
