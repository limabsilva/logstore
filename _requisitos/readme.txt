Este projeto utiliza Entity Framework para criar a base de dados
com seus devidos relacionamentos e realizar operações simples de cadastro.

1) Para criar a base de dados execute o 
comando abaixo no terminal do projeto HungryPizza.Persistence:
	dotnet ef database update
	
	Deverá aparecer a seguinte mensagem de sucesso: "Applying migration '20220827140000_CreateDatabase'. Done."
	
	
	
Documentação em https://localhost:7101/swagger/index.html	
Endpoint: Pizza
pizza/register
{
  "flavor": "3 Queijos",
  "ingredients": "Queijo prato, muçarela e catupiry.",
  "available": true,
  "price": 50,
  "size": "FAMÍLIA"
}
{
  "flavor": "Frango com requeijão",
  "ingredients": "Frango, milho, requeijão e muçarela.",
  "available": true,
  "price": 59.99,
  "size": "FAMÍLIA"
}	
{
  "flavor": "Muçarela",
  "ingredients": "Muçarela com orégano.",
  "available": true,
  "price": 42.50,
  "size": "FAMÍLIA"
}	
{
  "flavor": "Calabresa",
  "ingredients": "Calabresa, cebola e muçarela.",
  "available": true,
  "price": 42.50,
  "size": "FAMÍLIA"
}	
{
  "flavor": "Pepperoni",
  "ingredients": "Pepperoni com orégano.",
  "available": true,
  "price": 55,
  "size": "FAMÍLIA"
}	
{
  "flavor": "Portuguesa",
  "ingredients": "Cebola, tomate, pimentação, ovos cozido e muçarela.",
  "available": true,
  "price": 45,
  "size": "FAMÍLIA"
}	
{
  "flavor": "Veggie",
  "ingredients": "Rúcula, alface, manjericão, molho de tomate, cebola.",
  "available": true,
  "price": 59.99,
  "size": "FAMÍLIA"
}
	