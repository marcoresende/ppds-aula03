#[**Início**]()

## **API - Consulta V1**

	- Disponibiliza serviços para consulta de dados da Prefeitura.

### Dados para Teste

  - { Id = 1, Logradouro = "Rua a", Categoria = "residencial", Iptu = 119.90M }
  - { Id = 2, Logradouro = "Rua b", Categoria = "residencial", Iptu = 339.75M }
  - { Id = 3, Logradouro = "Rua c", Categoria = "comercial", Iptu = 216.99M }
  - { Id = 4, Logradouro = "Rua d", Categoria = "residencial", Iptu = 216.99M }
  - { Id = 5, Logradouro = "Rua e", Categoria = "comercial", Iptu = 216.99M }

### Descrição dos Serviços

#### Consulta de IPTU

	- Recebe o código cadastral do imóvel e devolve o imposto a ser pago.
	- Tipo de dados de entrada: application/json
	- Tipo de dados de retorno: application/json

	##### URL: /api/v1/consulta/iptu/{id}

	##### Entrada

	 - id : Numérico.

	##### Retorno

	 - Id : Numérico
     - Logradouro : Alfanumérico
     - Categoria : Alfanumérico
     - Iptu : Numérico



