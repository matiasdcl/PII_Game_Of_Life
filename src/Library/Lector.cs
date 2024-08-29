using System.IO;
namespace Ucu.Poo.GameOfLife;
/*
 Esta clase se encarga de recibir un archivo que trae almacenado un string
 y lo separa por linea. Su único motivo de cambio es si se desea modificar 
 ese manejo del texto. No tiene colaboradores.
 */
public class Lector
{
    public static string[] Leer(string url)
    {
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        return contentLines;
    }
}