public class Producto
{
    private string nombre;
    private DateTime fechavencimiento;
    private float precio; //entre 1000 y 5000;
    private string tamanio;

    public string Nombre { get => nombre; set => nombre = value; }
    public DateTime Fechavencimiento { get => fechavencimiento; set => fechavencimiento = value; }
    public float Precio { get => precio; set => precio = value; }
    public string Tamanio { get => tamanio; set => tamanio = value; }

    public Producto()
    {
        string[] nombres= {"papas fritas","dulce de leche","vino","aceite"};
        string[] fechas= {"30/06/2023", "28/02/2023","15/04/2023"};
        string[] tamanios= {"pequenio","mediano","grande"};

        Random a= new Random();
        Nombre= nombres[a.Next(0,4)];
        Fechavencimiento= Convert.ToDateTime(fechas[a.Next(0,3)]);
        Tamanio= tamanios[a.Next(0,3)];
        Precio= a.Next(1000, 5000);
    }
}


