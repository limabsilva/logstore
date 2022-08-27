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
  "size": "Família"
}	
	