using System;
using System.Text;
using System.Threading;

namespace GameOfLife
{
    public class Printer
    {
        public static void Imprimir(string url)
        {
            bool[,] b = LectorArchivo.TableroInicial(url);
            int width = b.GetLength(0); //variabe que representa el ancho del tablero
            int height = b.GetLength(1); //variabe que representa altura del tablero
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(b[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                //=================================================
                b = Reglas.Logica(b); //Invocar método para calcular siguiente generación
                //=================================================
                Thread.Sleep(300);
            }
        }
    }
}
