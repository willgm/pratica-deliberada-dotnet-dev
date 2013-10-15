#Exercício 2 - Consumindo um serviço REST

Faça os testes existentes na classe ProjetosClient e que estão falhando passarem.

Antes de começar execute o comando a seguir no Package Manager Console.
Este comando deverá resultar na carga do banco de dados utilizado pelo serviço REST.

    Update-Database -ProjectName PDDND.ThirdPartyServices

##Motivações para este exercício:

1. Cenário de resolução de um problema parecido com outros problemas já resolvidos na base de código.
2. Conhecer as APIs do pacote Microsoft.AspNet.WebApi.Client
3. Fácil cenário para praticar o princípio DRY (don't repeat yourself)