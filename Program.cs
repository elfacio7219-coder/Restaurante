// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Clientes
{
    public int id {get; set;}
    public string? cedula {get; set;}
    public string? nombre {get; set;}
    public string? correo {get; set;}
    public DateTime fecha {get; set;}
    public Boolean activo {get; set;}
    public List<Ventas>? Ventas { get; set; }
    
}

public class Productos
{
    public int id {get; set;}
    public string? codigo {get; set;}
    public string? nombre {get; set;}
    public Decimal valor {get; set;}
    public List<Ventas_Productos>? Ventas_Productos { get; set; }
   
}

public class Ventas
{
    public int id {get; set;}
    public string? codigo {get; set;}
    public int cliente {get; set;}
    public DateTime fecha {get; set;}
    public Decimal descuento {get; set;}
    public Clientes? _cliente {get; set;}
    public List<Ventas_Productos>? Ventas_Productos { get; set; }
    
}
public class Venta_productos
{
    public int id { get; set; }
    public int venta { get; set; }
    public int producto { get; set; }
    public decimal cantidad { get; set; }
    public decimal valor { get; set; }
    public decimal subTotal { get; set; }    
    
}