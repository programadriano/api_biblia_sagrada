# Introdução
Api desenvolvida para listar os livros, capitulos e versos da biblia sagrada

# Dependencias
* .NET Core 3.1
*  SQL Server

# Setup

## Banco de dados
O primeiro passo será a carga do banco de dados. Para isso, execute o script que esta dentro do diretório \Scripts_Banco_de_dados\biblia_bkp.sql.

Com a carga OK, atualize os arquivos *appsettings.json*, *appsettings.Development.json* com a sua string de conexão.

## Documentação

<details>
  <summary>
    <b>Buscar Livros</b> - <i>retorna os 66 livros da Biblia</i>
  </summary>
  <br/>
  
  <b>Endpoint:</b> `GET /api/Livros`
  <br /><br />
  ```
  [
  {
    "nome": "Gênesis",
    "capitulos": 50,
    "sigla": "gn",
    "testamento": 1
  },
  {
    "nome": "Êxodo",
    "capitulos": 40,
    "sigla": "ex",
    "testamento": 1
  },
  {
    "nome": "Levítico",
    "capitulos": 27,
    "sigla": "lv",
    "testamento": 1
  }
  ...
  ]
  ```
  Nesse endpoint estamos retornando: Nome do livro, a quantidade de capitulos que ele tem, a sigla para pesquisa paginada e o testamento 1 Velho testamento e o 2 Novo Testamento.
</details>


<details>
  <summary>
    <b>Buscar por Capitulo</b> - <i>retorna todos versos de um capitulo</i>
  </summary>
  <br/>
  
  <b>Endpoint:</b> `GET /api/Livros/{sigla}/{capitulo}`
  <br /><br />
  ```
 [
  {
    "versiculo": 1,
    "texto": "No princípio Deus criou os céus e a terra."
  },
  {
    "versiculo": 2,
    "texto": "Era a terra sem forma e vazia; trevas cobriam a face do abismo, e o Espírito de Deus se movia sobre a face das águas."
  },
  {
    "versiculo": 3,
    "texto": "Disse Deus: \"Haja luz\", e houve luz."
  },
  {
    "versiculo": 4,
    "texto": "Deus viu que a luz era boa, e separou a luz das trevas."
  },
  {
    "versiculo": 5,
    "texto": "Deus chamou à luz dia, e às trevas chamou noite. Passaram-se a tarde e a manhã; esse foi o primeiro dia."
  }
  ...
 ]
  ```
  Nesse endpoint estamos retornando todos versos de um capitulo.
</details>


<details>
  <summary>
    <b>Buscar por Versiculo</b> - <i>retorna um determinado versiculo de um capitulo</i>
  </summary>
  <br/>
  
  <b>Endpoint:</b> `GET /api/Livros/{sigla}/{capitulo}/{versiculo}`
  <br /><br />
  ```
 [
  {
    "versiculo": 1,
    "texto": "No princípio Deus criou os céus e a terra."
  }
]
  ```
  Nesse endpoint estamos retornando todos versos de um capitulo.
</details>

