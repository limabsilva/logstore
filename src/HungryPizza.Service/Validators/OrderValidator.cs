using HungryPizza.Domain.Entities;

namespace HungryPizza.Service.Validators;
public static class OrderValidator
{

    public static bool IsValidOrder(List<OrderItemEntity> orderItemEntities)
    {
        if (orderItemEntities.Count <= 10)
            return true;
        else
            return false;
    }
    public static bool IsValidOrderItem(List<OrderItemEntity> orderItemEntities)
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

    public static decimal CalculateFreight()
    {
        return 0;
    }
}