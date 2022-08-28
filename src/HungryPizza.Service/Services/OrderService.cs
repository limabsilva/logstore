using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Constants;
using HungryPizza.Domain.Contracts.Response;
using HungryPizza.Service.Interfaces;
using HungryPizza.Service.Validators;
using HungryPizza.Persistence.Interfaces;
using Microsoft.Extensions.Logging;
using System.Text;

namespace HungryPizza.Service.Services;
public class OrderService : IOrderService
{
    private readonly ILogger _logger;
    private readonly IOrderRepository _orderRepository;
    private readonly IOrderItemRepository _orderItemRepository;
    private readonly IItemFlavorsRepository _itemFlavorsRepository;
    private readonly IPizzaFlavorService _pizzaFlavorService;
    private readonly OrderValidator _orderValidator;

    public OrderService(ILogger<OrderService> logger,
        IOrderRepository orderRepository,
        IOrderItemRepository orderItemRepository,
        IItemFlavorsRepository itemFlavorsRepository,
        IClientService clientService,
        IPizzaFlavorService pizzaFlavorService)
    {
        _logger = logger;
        _orderRepository = orderRepository;
        _orderItemRepository = orderItemRepository;
        _itemFlavorsRepository = itemFlavorsRepository;
        _orderValidator = new OrderValidator(clientService);
        _pizzaFlavorService = pizzaFlavorService;
    }

    public async Task<string> RegisterOrder(ClientEntity clientEntity, OrderEntity orderEntity, List<OrderItemEntity> orderItemEntityList)
    {
        string ret;
        if (orderItemEntityList != null)
        {
            if (!_orderValidator.IsValidOrder(orderItemEntityList))
                return "Um pedido pode ter até 10 pizzas. Favor rever o corpo da requisição e tente novamente.";

            if (!_orderValidator.IsValidOrderItem(orderItemEntityList))
                return "Uma pizza pode ter até 2 sabores. Favor rever o corpo da requisição e tente novamente.";

            if (clientEntity != null)
            {
                ClientEntity client = new ClientEntity();
                if (!String.IsNullOrEmpty(clientEntity.Telephone))
                {
                    client = _orderValidator.IsExistsClient(clientEntity.Telephone);
                }
                else
                {
                    client = clientEntity;
                    var clientDefault = _orderValidator.IsExistsClient(OrderConfigConstant.PhoneClientNotRegisted);
                    if (clientDefault != null)
                    {
                        client.Id = clientDefault.Id;
                        orderEntity.Description += " - Cliente: " + client.Name;
                    }
                    else
                        return "Cliente padrão do sistema não encontrato. Favor contactar administrador do sistema.";

                }
                orderEntity.ClientID = client.Id;
                orderEntity.DeliveryAddress = SetDeliveryAddress(client);

                #region//Validar Sabores
                decimal pricePizza = 0;
                decimal priceOrder = 0;
                foreach (var item in orderItemEntityList)
                {

                    foreach (var pizzaItem in item.ItemFlavorsOrderList)
                    {
                        var iPizza = await _pizzaFlavorService.GetOnePizza(pizzaItem.PizzaFlavorID);
                        if (iPizza != null)
                        {
                            if (!iPizza.FirstOrDefault().Available)
                                return $"Pizza de {iPizza.FirstOrDefault().Flavor} não está indiponível. Favor rever seu pedido.";

                            pricePizza += iPizza.FirstOrDefault().PricePizza;
                        }
                    }
                    item.PriceItem = (pricePizza / item.ItemFlavorsOrderList.Count);
                    priceOrder += item.PriceItem;
                    pricePizza = 0;
                }
                #endregion//Validar Sabores


                decimal priceFreight = _orderValidator.CalculateFreight();
                priceOrder += priceFreight;

                orderEntity.PriceTotal = priceOrder;

                try
                {
                    orderEntity.Register = DateTime.Now;
                    await _orderRepository.Create(orderEntity);
                    var resultOrder = await _orderRepository.SaveChangesAsync();
                    if (resultOrder.IsSuccess)
                    {
                        foreach (var item in orderItemEntityList)
                        {
                            item.Register = DateTime.Now;
                            item.OrderID = orderEntity.Id;
                            await _orderItemRepository.Create(item);
                            var resultItem = await _orderItemRepository.SaveChangesAsync();
                            if (!resultItem.IsSuccess)
                            {
                                _logger.LogError("Falha ao registrar os sabores do seu pedido. Favor tente novamente.");
                                return "Falha ao registrar os sabores do seu pedido. Favor tente novamente.";
                            }
                        }
                        return "Pedido registrado com sucesso!";
                    }
                    else
                    {
                        _logger.LogError("Falha ao cadastrar pedido: " + resultOrder.Errors.ToString());
                        return "Falha ao cadastrar seu pedido. Tente novamente.";
                    }
                }
                catch (Exception ex)
                {
                    ret = "Falha ao cadastrar seu pedido: " + ex.Message;
                    _logger.LogError(ret);
                    return ret;

                }

            }
            else
            {
                ret = "Objeto [ClientEntity] inválido.";
                _logger.LogError(ret);
                return ret;
            }
        }
        else
        {
            ret = "Objeto [List<OrderItemEntity>] inválido.";
            _logger.LogError(ret);
            return ret;
        }
    }

    protected static string SetDeliveryAddress(ClientEntity clientEntity)
    {
        StringBuilder deliveryAddres = new StringBuilder();
        deliveryAddres.Append(clientEntity.StreetName + ", ");
        deliveryAddres.Append(clientEntity.Number + " - ");
        deliveryAddres.Append(clientEntity.Complement + "  ");
        deliveryAddres.Append(clientEntity.Neighborhood + " - ");
        deliveryAddres.Append(clientEntity.City + " - ");
        deliveryAddres.Append(clientEntity.State + " - ");
        deliveryAddres.Append(clientEntity.ZipCode);

        return deliveryAddres.ToString();
    }
    
}

