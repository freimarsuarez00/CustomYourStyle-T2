
using CustomYourStyle.Entities;
using CustomYourStyle.Entities.Constants;
using CustomYourStyle.Handler;
using CustomYourStyle.Repository;

Console.WriteLine("Custom Your Style");


PedidoRepository pedidoRepository = new PedidoRepository();
PedidoHandler _Pedido = PedidoHandler.Instancia(pedidoRepository);


Categoria categoria = new Categoria() { 
    IdCategoria=0,
    Nombre="Ropa",
    Descripcion="Ropa"
};

var builder = new ProductoBuilder(categoria);
var producto = builder.SetTallaRopa("S")
                      .SetColorRopa("Negro")
                      .Build();

var pedido = new Pedido
{
    IdPedido = 0,
    FechaCreacion = DateTime.Now,
    Estado = "En Proceso",
    Total = 2000,
    Cliente = new Cliente()
    {
        Nombre="Jose", 
        Apellido="Carrillo"
    },
    Productos = new List<Producto> { producto }
};


//var _Pedido = PedidoHandler.Instancia;
int pedidoId = _Pedido.AddPedido(pedido);
_Pedido.ActualizarEstadoPedido(pedidoId, Estados.Procesado.ToString());


var jogger = new Ropa
{
    Nombre = "Jogger",
    Categoria = new()
    {
        IdCategoria=0,
        Nombre = "Ropa", 
        Descripcion = "Ropa"
        
    },
    Color = "Rojo",
    Tela = new Tela()
    {
        IdTela=1,
        Nombre="Algodon", 
        MaterialPrincipal="Algodon",
        PorcentajeUso=90
    },
    Talla = "S",
    Marca = new Marca()
    {
        IdMarca=1,
        Nombre="CruceHose",
        Pais="Colombia"
    }
};


Cliente clienteJose = new Cliente()
{
    Nombre = "Jose"
};


var pedidoOriginal = new Pedido
{
    Cliente = clienteJose,
    Productos = [jogger]
};
_Pedido.AddPedido(pedidoOriginal);



var productoClonado = jogger.Clonar();

var pedidoClonado = new Pedido
{
    Cliente = clienteJose,
    Productos = [productoClonado]
};

int idPedidoClonado = _Pedido.AddPedido(pedidoClonado);
_Pedido.ActualizarEstadoPedido(idPedidoClonado, Estados.Completado.ToString());



var allPedidos = _Pedido.GetAllPedidos();




Console.WriteLine("+------------+----------------+----------------+");
Console.WriteLine("| Pedido ID | Cliente        | Estado         |");
Console.WriteLine("+------------+----------------+----------------+");

foreach (var item in allPedidos)
{
    Console.WriteLine($"| {item.IdPedido,-10} | {item.Cliente.Nombre,-14} | {item.Estado,-14} |");
    Console.WriteLine("+------------+----------------+----------------+");
}

if (allPedidos.Count == 0)
{
    Console.WriteLine("--------------");
    Console.WriteLine("Not Data found");
}
