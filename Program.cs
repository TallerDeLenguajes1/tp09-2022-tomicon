// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el path de la carpeta:");
string path= Console.ReadLine();
if (Directory.Exists(path))
{
    List<string> archivos = new List<string>();
    archivos = Directory.GetFiles(path).ToList();
    Console.WriteLine("Estos son los archivos que se encuentran dentro del path:");
    foreach (string item in archivos)
    {
        Console.WriteLine(item);
    }
    List<string> renglones = new List<string>();
    int i=1;
    foreach (var item in archivos)
    {
        string nombre= Path.GetFileNameWithoutExtension(item);
        string extension = Path.GetExtension(item);
        string linea = i + "," + nombre + "," + extension;
        i++;
        renglones.Add(linea);
    }
    File.WriteAllLines(@"C:\tp08-2022-tomicon\index.csv",renglones);
} else
{
    Console.WriteLine("La ruta ingresada no existe");
}


