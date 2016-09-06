#[**Voltar**](https://github.com/marcoresende/ppds-aula03/blob/master/README.md)

## **API - Pedido v1**

	- Disponibiliza API para agendamento de pedidos.

### Descrição dos Serviços

#### **Pedido de Adoção de Cães**

	- Recebe o CPF, endereço e dados cadastrais do cidadão.

##### URL: /api/v1/pedido/adocaocaes
##### Método: POST

##### Entrada:
	
	 Tipo de dado: application/json
	 - Cpf : Alfanumérico
     - Nome : Alfanumérico
     - Logradouro : Alfanumérico

##### Retorno:

	 - Pedido : Numérico
     - Cpf : Alfanumérico
     - Nome : Alfanumérico
     - Logradouro : Alfanumérico
     - Status : Alfanumérico

#### **Pedido de Adoção de Gatos**

	- Recebe o CPF, endereço e dados cadastrais do cidadão.

##### URL: /api/v1/pedido/adocaogato
##### Método: POST

##### Entrada:
	
	 Tipo de dado: application/json
	 - Cpf : Alfanumérico
     - Nome : Alfanumérico
     - Logradouro : Alfanumérico

##### Retorno:

	 - Pedido : Numérico
     - Cpf : Alfanumérico
     - Nome : Alfanumérico
     - Logradouro : Alfanumérico
     - Status : Alfanumérico

