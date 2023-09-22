Esse desafio consiste em CRUD criado em Console Application.
Utilizei o Entity Framework para conexão com o banco de dados SQL Server.
Na pasta Entities se encontra o modelo que representa o produto
Na pasta Data se encontra os dados relacionados ao banco de dados, como o contexto para oersistencia dos dados e um repositorio que contem a logica do CRUD
As tavelas foram geradas usando as migrations do entity framework core
Para melhor separação de responsabilidade a classe Interface de interação contém a lógica de interacao com o usuário onde sao chamados os metodos para persistência dos dados no Banco de dados
Para poder utilizar você terá que atualizar a string de conexao do seu banco SqlServer que se encontra na classe ApplicationDbContext, dentro da pasta Data
Em seguida executar o comando Update-Database no seu Package Manager Console para gerar o banco de dados
Depois é so executar, foi utilizado a versao 7.0 do .NET
