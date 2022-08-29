using HungryPizza.Domain.Entities;
using HungryPizza.Service.Interfaces;

namespace HungryPizza.Service.Validators;
public class OrderValidator
{
    private readonly IClientService _clientService;
    public OrderValidator(IClientService clientService)
    {
        _clientService = clientService;
    }

    public ClientEntity IsExistsClient(string numberPhone)
    {
        return _clientService.GetClientByTelephone(numberPhone);
    }

    public bool IsValidOrder(List<OrderItemEntity> orderItemEntities)
    {
        if (orderItemEntities.Count <= 10)
            return true;
        else
            return false;
    }
    public bool IsValidOrderItem(List<OrderItemEntity> orderItemEntities)
    {
        foreach (var item in orderItemEntities)
        {
            if (item.ItemFlavorsOrderList != null)
            {
                if (item.ItemFlavorsOrderList.Count > 2)
                    return false;
            }
            else
                return false;
        }
        return true;
    }

    public decimal CalculateFreight()
    {
        return 0;
    }
}