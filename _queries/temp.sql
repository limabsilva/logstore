--delete from [dbo].[PizzaFlavor];

select 
	PF.PizzaFlavorID,
	PFP.PizzaFlavorsPriceID,
	PF.Flavor,
	PF.Ingredients,
	PF.Available,
	PFP.Price,
	PFP.Size
from [dbo].[PizzaFlavor] PF INNER JOIN [dbo].[PizzaFlavorsPrice] PFP ON PFP.PizzaFlavorEntityID = PF.PizzaFlavorID;



select * from [dbo].[PizzaFlavorsPrice];