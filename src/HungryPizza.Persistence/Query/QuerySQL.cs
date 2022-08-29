using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryPizza.Persistence.Query;
public static class QuerySQL
{
	public const string ListAllPizzas = @"select 
												PF.PizzaFlavorID,
												PF.Flavor,
												PF.Ingredients,
												PF.Available,
												PFP.Price AS PricePizza,
												PFP.Size AS SizePizza
											from [dbo].[PizzaFlavor] PF 
											INNER JOIN [dbo].[PizzaFlavorsPrice] PFP 
												ON PFP.PizzaFlavorEntityID = PF.PizzaFlavorID";

	public const string GetOnePizza = @"select 
											PF.PizzaFlavorID,
											PF.Flavor,
											PF.Ingredients,
											PF.Available,
											PFP.Price AS PricePizza,
											PFP.Size AS SizePizza
										from [dbo].[PizzaFlavor] PF INNER JOIN [dbo].[PizzaFlavorsPrice] PFP ON PFP.PizzaFlavorEntityID = PF.PizzaFlavorID
										where PF.PizzaFlavorID = @PizzaFlavorID";

	public const string GetAllOrdersByClient = @"SELECT	C.Telephone 'TELEFONE', 
															C.Name 'CLIENTE', 
															O.OrderID 'PEDIDO',
															O.Register 'DATA_HORA',
															O.PriceTotal 'VALOR_PEDIDO_COM_FRETE',
															SUM(OI.PriceItem) 'VALOR_PEDIDO',
															COUNT(1) 'QTD_PIZZAS'
													FROM [dbo].Client C INNER JOIN [Order] O on O.ClientID = C.ClientID
															INNER JOIN OrderItem OI on OI.OrderID = O.OrderID
													WHERE C.Telephone = @PhoneNumber
													GROUP BY C.Telephone, 
															C.Name, 
															O.OrderID,
															O.Register,
															O.PriceTotal";

}

