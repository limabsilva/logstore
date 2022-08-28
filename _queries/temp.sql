--delete from [dbo].[PizzaFlavor];
delete from [dbo].[PizzaFlavorsPrice];

select 
	PF.PizzaFlavorID,
	PF.Flavor,
	PF.Ingredients,
	PF.Available,
	--PFP.PizzaFlavorsPriceID AS 'Price.PricePizzaID',
	PFP.Price AS 'Price.PricePizza',
	PFP.Size AS 'Price.SizePizza'
from [dbo].[PizzaFlavor] PF INNER JOIN [dbo].[PizzaFlavorsPrice] PFP ON PFP.PizzaFlavorEntityID = PF.PizzaFlavorID
FOR JSON PATH, ROOT('Pizzas');

select 
				PF.PizzaFlavorID,
				PF.Flavor,
				PF.Ingredients,
				PF.Available,
				PFP.Price AS PricePizza,
				PFP.Size AS SizePizza
			from [dbo].[PizzaFlavor] PF INNER JOIN [dbo].[PizzaFlavorsPrice] PFP ON PFP.PizzaFlavorEntityID = PF.PizzaFlavorID


--select * from [dbo].[PizzaFlavorsPrice];

select * from [dbo].Client
select * from [Order]
