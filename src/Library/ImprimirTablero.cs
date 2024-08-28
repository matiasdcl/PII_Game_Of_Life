using System;
using System.Text;
using System.Threading;
namespace Ucu.Poo.GameOfLife;

public class ImprimirTablero
{
    public static void Imprimir()
    {
        bool[,] b = InicioTablero.CrearTablero();
        /*int width //variabe que representa el ancho del tablero
        int height //variabe que representa altura del tablero*/
        int width = b.GetLength(0);
        int height = b.GetLength(1);
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
            //Invocar método para calcular siguiente generación
            Funcionamiento.SiguienteIteracion(b);
            //=================================================
            Thread.Sleep(300);
        }
    }
}