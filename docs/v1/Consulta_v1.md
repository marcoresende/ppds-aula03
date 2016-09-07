#[**Voltar**](https://github.com/marcoresende/ppds-aula03/blob/master/README.md)

## **API - Consulta v1**

	- Disponibiliza serviços para consulta de dados da Prefeitura.

### Dados para Teste
####**Imóveis**
  - { Id = 1, Logradouro = "Rua a", Categoria = "residencial", Iptu = 119.90M }
  - { Id = 2, Logradouro = "Rua b", Categoria = "residencial", Iptu = 339.75M }
  - { Id = 3, Logradouro = "Rua c", Categoria = "comercial", Iptu = 216.99M }
  - { Id = 4, Logradouro = "Rua d", Categoria = "residencial", Iptu = 216.99M }
  - { Id = 5, Logradouro = "Rua e", Categoria = "comercial", Iptu = 216.99M }

####**Alunos**
  - { Codigo = 1, Nome = "José", Escola = "Escola 1"}
  - { Codigo = 2, Nome = "Maria", Escola = "Escola 1"}
  - { Codigo = 3, Nome = "João", Escola = "Escola 2"}
  - { Codigo = 4, Nome = "Pedro", Escola = "Escola 3"}
  - { Codigo = 5, Nome = "Felipe", Escola = "Escola 4"}

### Descrição dos Serviços

#### Consulta de IPTU

	- Recebe o código cadastral do imóvel e devolve o imposto a ser pago.

##### URL: /api/v1/consulta/iptu/{id}
##### Método: GET

##### Entrada:

	 - id : Numérico.

##### Retorno:

	 - Id : Numérico
     - Logradouro : Alfanumérico
     - Categoria : Alfanumérico
     - Iptu : Numérico

#### Consulta de Coleta de Lixo

 - Recebe o logradouro e retorna os dias da coleta de lixo. 
 - Endereços de **A** até **M**, os dias de coleta são: Terça-feira, Quinta-feira, Sábado.
 - Endereços de **N** até **Z**, os dias de coleta são: Segunda-feira, Quarta-feira, Sexta-feira.

##### URL: /api/v1/consulta/iptu/{logradouro}
##### Método: GET

##### Entrada:

	- logradouro : Alfanumérico.

	Exemplo: Rua Santa Rita, Avenida Afonso Pena, etc.

##### Retorno:

	- String com descrição dos dias.
	Exemplo: "Dias de coleta: Segunda-feira, Quarta-feira, Sexta-feira"

#### Consulta de Histórico de Aluno de Rede Pública

 - Recebe o código do aluno e retorna o histórico do mesmo. 

##### URL: /api/v1/consulta/historicoaluno/{id}
##### Método: GET

##### Entrada:

	- id : Numérico.

##### Retorno:

	- Codigo : Numérico,
  	- Nome : Alfanumérico,
  	- Escola : Alfanumérico,
  	- Disciplinas : Array de Objetos [{ Nome : Alfanumérico, Nota: Numérico, Faltas : Numérico }]