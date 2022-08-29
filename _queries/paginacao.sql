use dbHungryPizza;
GO
DECLARE @page tinyint = 4,
		@Offset tinyint = 0,
        @Next tinyint = 5;

if(@page = 1)
	set @offset = 0
else if(@page > 1)
	set @Offset = ((@page - 1) * @next)

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
ORDER BY O.Register DESC
OFFSET @Offset ROWS 
FETCH NEXT @Next ROWS ONLY

