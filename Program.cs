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
    
}

public class Productos
{
    public int id {get; set;}
    public string? codigo {get; set;}
    public string? nombre {get; set;}
    public Decimal valor {get; set;}
   
}

public class Ventas
{
    public int id {get; set;}
    public string? codigo {get; set;}
    public int cliente {get; set;}
    public DateTime fecha {get; set;}
    public Decimal descuento {get; set;}
    public Clientes? _cliente {get; set;}




    
}
public class Venta_productos
{
    
}