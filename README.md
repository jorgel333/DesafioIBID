Este desafio envolve a criação de um aplicativo de Console Application com operações CRUD (Create, Read, Update, Delete) usando o Entity Framework para se conectar a um banco de dados SQL Server.

A estrutura do projeto é organizada da seguinte forma:

A pasta "Entities" contém o modelo de domínio que representa o produto.
A pasta "Data" contém os componentes relacionados ao banco de dados, incluindo o contexto para persistência de dados e um repositório com consultas e operações no banco de dados.
As tabelas do banco de dados foram criadas usando as migrations do Entity Framework Core.
Para separação de responsabilidades, a classe "ChamarServiço" lida com a interação do usuário, configura o "IServiceCollection" para injeção de dependência e chama os métodos para persistência dos dados no banco de dados.
Uma classe de serviços também foi criada para separar a lógica de negócios da lógica de acesso aos dados.

Para executar o projeto, você precisará atualizar a string de conexão para seu banco de dados SQL Server, localizada na pasta "Extensions", dentro da classe "DependencyInjection". Em seguida, execute o comando "Update-Database" no Package Manager Console para gerar o banco de dados. Após essas etapas, você pode executar a aplicação. O projeto foi desenvolvido com o .NET 7.0.
