using System;
using System.Text;
using System.Threading;
namespace Ucu.Poo.GameOfLife;

public class ImprimirTablero
{
    public static void ImprimirEnConsola(Tablero tablero)
    {
        bool[,] b = tablero.Board; //llama al metodo/clase responsable de inicializar un tablero
        int width = b.GetLength(0);
        int height = b.GetLength(1);
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
        Thread.Sleep(300);
    }
}