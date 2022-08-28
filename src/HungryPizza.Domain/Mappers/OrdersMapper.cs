using HungryPizza.Domain.Contracts.Request;
using HungryPizza.Domain.Entities;

namespace HungryPizza.Domain.Mappers;
public static class OrdersMapper
{
    public static OrderEntity OrderEntityMapper(OrderRequest orderRequest)
    {
        return new OrderEntity()
        {
            Description = orderRequest.Description
        };
    }

    public static List<OrderItemEntity> OrderItemEntityMapper(OrderRequest orderRequest)
    {
        var orderItemEntityList = new List<OrderItemEntity>();
        var orderItemEntity = new OrderItemEntity();
        var itemFlavorsEntity = new ItemFlavorsEntity();
        var itemFlavorsEntityList = new List<ItemFlavorsEntity>();
        var pizzas = orderRequest.Pizzas;
        if (pizzas != null)
        {
            foreach (var itemPizza in pizzas)// até 10 pizzas
            {
                orderItemEntity.Comments = itemPizza.Comments;
                if (itemPizza.Pizza != null)
                {
                    foreach (var itemFlavor in itemPizza.Pizza) //até 2 sabores
                    {
                        itemFlavorsEntity.PizzaFlavorID = itemFlavor.PizzaFlavorID;
                        itemFlavorsEntityList.Add(itemFlavorsEntity);
                        itemFlavorsEntity = new ItemFlavorsEntity();
                    }
                }
                else
                {
                    //não possui sabor selecionado
                    return new List<OrderItemEntity>(); 
                }
                orderItemEntity.ItemFlavorsOrderList = itemFlavorsEntityList;
                orderItemEntityList.Add(orderItemEntity);
                itemFlavorsEntityList = new List<ItemFlavorsEntity>();
                orderItemEntity = new OrderItemEntity();
            }
        }
        else
        {
            //não possui nenhuma pedido de pizza
            return new List<OrderItemEntity>();
        }

        return orderItemEntityList;
    }
}

