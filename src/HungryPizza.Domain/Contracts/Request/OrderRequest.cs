using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryPizza.Domain.Contracts.Request;
public class OrderRequest
{    
    public ClientRequest? Client { get; set; }
    public string? Description { get; set; }
    public List<OrderItems>? Pizzas { get; set; }

}

public class OrderItems
{
    public List<Flavors>? Pizza { get; set; } //Máximo de 2 sabores por pizza/item do pedido
    public string? Comments { get; set; } //sem cebola
}

public class Flavors
{
    public int PizzaFlavorID { get; set; }
    
}

