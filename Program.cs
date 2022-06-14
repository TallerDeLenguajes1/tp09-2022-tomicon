using System.Text.Json;
Random aleatorio= new Random();
int cantProductos= aleatorio.Next(1,20);
List<Producto> listado_productos= new List<Producto>();
for (int i = 0; i < cantProductos; i++)
{
    Producto nuevo = new Producto();
    listado_productos.Add(nuevo);
}
string todos_productos= JsonSerializer.Serialize(listado_productos);
File.WriteAllText("index.json", todos_productos);

string json_productos = File.ReadAllText("index.json");
listado_productos= JsonSerializer.Deserialize<List<Producto>>(json_productos);
Console.WriteLine("Listado de productos:\n");
foreach (var producto in listado_productos)
{
    Console.WriteLine("Nombre: " + producto.Nombre);
    Console.WriteLine("Tamanio: " + producto.Tamanio);
    Console.WriteLine("Fecha de vencimiento: " + producto.Fechavencimiento);
    Console.WriteLine("Precio: " + producto.Precio);
}


