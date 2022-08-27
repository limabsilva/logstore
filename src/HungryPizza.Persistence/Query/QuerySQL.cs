using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryPizza.Persistence.Query;
public static class QuerySQL
{
	public static string ListAllPizzas = @"select 
				PF.PizzaFlavorID,
				PF.Flavor,
				PF.Ingredients,
				PF.Available,
				PFP.Price AS PricePizza,
				PFP.Size AS SizePizza
			from [dbo].[PizzaFlavor] PF INNER JOIN [dbo].[PizzaFlavorsPrice] PFP ON PFP.PizzaFlavorEntityID = PF.PizzaFlavorID";
}

