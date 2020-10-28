# Introdução
Api desenvolvida para listar os livros, capitulos e versos da biblia sagrada

# Dependencias
* .NET Core 3.1
*  SQL Server
*  Redis

# Setup

## Banco de dados
O primeiro passo sera a carga do banco de dados. Para isso, execute o script que esta dentro do diretório \Scripts_Banco_de_dados\biblia_bkp.sql desse projeto.

## Redis
O redis pode ser utilizado como um serviço externo ou com o Docker. Basta adicionar os seus dados de conexão no arquivo *appsettings.json*, *appsettings.Development.json*.

## Configuração das conexões 



