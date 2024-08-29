using System.IO;

namespace Ucu.Poo.GameOfLife;

public class Lector
{
    public static string[] Leer(string url)
    {
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        return contentLines;
    }
}