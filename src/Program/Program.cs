namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main()
        {
            string[] matriz = Lector.Leer("board.txt");
            Tablero tablero = new Tablero(matriz);
            while(true)
            {
                ImprimirTablero.Imprimir(tablero); 
                Funcionamiento.SiguienteIteracion(tablero); 
            }
        }
    }
}