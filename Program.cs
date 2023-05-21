// C# program to illustrate how
// to read a file in C#
using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        //Ignora las clases 

        // Esto es el texto que se va a incluir en el archivo txt que crearas
        string text = "This is some cola.";
        // Esto es el path donde se va a crear el archivo y donde lo vas a leer
        // el path es el camino que sigue la compu para encontrar el archivo
        // El que tengo es uno absoluto, es decir, le digo que lo busque en ese lugar
        // Especificando desde que disco encontrarlo, por eso solo funciona en mi pc
        // Lo que quiero que hagas es que lo hagas relativo, es decir que funcione
        // En cualquier compu

        // j.txt es el nombre del archivo
        // \archivos es su carpeta
        // y asi sucesivamente
        string path = @"C:\Users\Linux-1\source\repos\Pruebas\archivos\j.txt";

        //Esto de aqui crea un archivo txt en el path que le asignes
        // No necesitas entenderlo, no le muevas
        using (FileStream oFS = File.Create(path)) 
        {
            Byte[] texto = new UTF8Encoding(true).GetBytes(text);
            oFS.Write(texto, 0, texto.Length);
        }

        // Esto lee el texto que esta adentro del archivo
        Console.WriteLine(File.ReadAllText(path));

    }
}
