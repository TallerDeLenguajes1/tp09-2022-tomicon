// See https://aka.ms/new-console-template for more information
using System.Text.Json;
Console.WriteLine("Ingrese el path de la carpeta:");
string path= Console.ReadLine();
if (Directory.Exists(path))
{
    List<string> archivos = new List<string>();
    List<Archivo> lista_archivos = new List<Archivo>();
    archivos = Directory.GetFiles(path).ToList();
    Console.WriteLine("Estos son los archivos que se encuentran dentro del path:");
    int i=1;
    foreach (string item in archivos)
    {
        Console.WriteLine(item);
        Archivo nuevo = new Archivo();
        nuevo.Nombre = Path.GetFileNameWithoutExtension(item);
        nuevo.Extencion= Path.GetExtension(item);
        nuevo.Numero = i;
        i++;
        lista_archivos.Add(nuevo);
    }
    string json_archivos= JsonSerializer.Serialize(lista_archivos);
    File.WriteAllText("index.json",json_archivos);

} else
{
    Console.WriteLine("La ruta ingresada no existe");
}
