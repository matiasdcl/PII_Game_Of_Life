using System;
using System.Text;
using System.Threading;
namespace Ucu.Poo.GameOfLife;
/*
ImprimirTablero tiene la rsponsabilidad de mostrar el tablero. Su colaborador es Tablero.
El único motivo de cambio que tiene esta clase sería agregar un nuevo medio de impresión, cumpliendo 
con el SRP.
 */
public class ImprimirTablero
{
    public static void ImprimirEnConsola(Tablero tablero)  //Imprime el tablero en la consola
    {
        bool[,] b = tablero.Board;
        int width = b.GetLength(0);
        int height = b.GetLength(1);
        Console.Clear();
        Console.WriteLine("\x1b[3J");
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
        Thread.Sleep(500);
    }
}