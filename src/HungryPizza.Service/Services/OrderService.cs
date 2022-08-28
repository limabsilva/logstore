using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Contracts.Response;
using HungryPizza.Service.Interfaces;
using HungryPizza.Persistence.Interfaces;
using Microsoft.Extensions.Logging;

namespace HungryPizza.Service.Services;
public class OrderService : IOrderService
{
    private readonly ILogger _logger;
    private readonly IOrderRepository _orderRepository;

    public OrderService(ILogger<OrderService> logger,
        IOrderRepository orderRepository)
    {
        _logger = logger;
        _orderRepository = orderRepository;
    }

    public async Task<string> RegisterOrder(ClientEntity clientEntity, OrderEntity orderEntity, List<OrderItemEntity> orderItemEntityList)
    {
        string ret;
        if (clientEntity != null)
        {
            //try
            //{
            //    clientEntity.Register = DateTime.Now;
            //    await _clientRepository.Create(clientEntity);
            //    var result = await _clientRepository.SaveChangesAsync();
            //    if (result.IsSuccess)
            //    {
            //        ret = "Cliente cadastrado com sucesso!";
            //        return ret;
            //    }
            //    else
            //    {
            //        _logger.LogError("Falha ao cadastrar Cliente: " + result.Errors.ToString());
            //        return "Falha ao cadastrar Cliente.";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ret = "Falha ao cadastrar Cliente: " + ex.Message;
            //    _logger.LogError(ret);
            //    return ret;

            //}
            return "Sucesso!";
        }
        else
        {
            ret = "Objeto [ClientEntity] inválido.";
            _logger.LogError(ret);
            return ret;
        }
    }
}

