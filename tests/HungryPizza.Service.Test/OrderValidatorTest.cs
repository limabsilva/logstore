using Xunit;
using HungryPizza.Service.Validators;
using HungryPizza.Domain.Entities;
using System.Collections.Generic;
using Moq;

namespace HungryPizza.Service.Test
{
    public class OrderValidatorTest
    {

        [Theory(DisplayName = "Testar se irá retornar TRUE em caso de número de pizzas dentro do limite(10).")]
        [InlineData(4)]
        [InlineData(10)]
        [InlineData(1)]
        [InlineData(9)]
        public void IsValidOrderTest_ShouldReturnTrue(int countList)
        {
            List<OrderItemEntity> orderItemEntities = new List<OrderItemEntity>(countList);
            for (int i = 0; i < countList; i++)
            {
                orderItemEntities.Add(new OrderItemEntity());
            }
            var returnMethod = OrderValidator.IsValidOrder(orderItemEntities);
            Assert.True(returnMethod);
        }

        [Theory(DisplayName = "Testar se irá retornar FALSE em caso de número excedente de pizzas")]
        [InlineData(12)]
        [InlineData(45)]
        [InlineData(11)]
        [InlineData(19)]
        public void IsValidOrderTest_ShouldReturnFalse(int countList)
        {
            List<OrderItemEntity> orderItemEntities = new List<OrderItemEntity>(countList);
            for (int i = 0; i < countList; i++)
            {
                orderItemEntities.Add(new OrderItemEntity());
            }
            var returnMethod = OrderValidator.IsValidOrder(orderItemEntities);
            Assert.False(returnMethod);
        }
    }
}