

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
select * from [OrderItem]
select * from [ItemFlavors]

SELECT	C.Telephone 'TELEFONE', 
		C.Name 'CLIENTE', 
		O.OrderID 'Nº PEDIDO',
		O.Register 'DATA/HORA',
		O.PriceTotal 'VALOR DO PEDIDO + FRETE',
		SUM(OI.PriceItem) 'VALOR DO PEDIDO',
		COUNT(1) 'QUANTIDADE DE PIZZAS'
FROM [dbo].Client C INNER JOIN [Order] O on O.ClientID = C.ClientID
		INNER JOIN OrderItem OI on OI.OrderID = O.OrderID
WHERE C.Telephone = '21987930138'
GROUP BY C.Telephone, 
		C.Name, 
		O.OrderID,
		O.Register,
		O.PriceTotal


select * from [OrderItem]
select * from [ItemFlavors]

