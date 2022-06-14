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




