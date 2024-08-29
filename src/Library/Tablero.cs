namespace Ucu.Poo.GameOfLife;
/*
La responsabilidad de Tablero es crear un tablero. Solo se modificaría este código si se 
deseara modificar el contenido o la distribucion del tablero, cumple con el SRP.
*/
public class Tablero
{
    private bool[,] board;
    public bool [,] Board
    {
        get { return this.board; }
        set { this.board = value; }
    }
    public Tablero(string[] contentLines) //constructor de Tablero
    {
        this.board = new bool[contentLines.Length, contentLines[0].Length];
        for (int  y = 0 ; y<contentLines.Length;y++)
        {
            for (int x=0; x<contentLines[y].Length; x++)
            {
                if(contentLines[y][x]=='1')
                {
                    this.board[x,y]=true;
                }
            }
        }
    }
}