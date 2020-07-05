# Sistema Roll Festas
### Versão Alpha 

###### Go to develop 
`$ git checkout develop`



##### Descrição

O objetivo deste software é de controle e automação de tarefas realizadas no cotidiano do estabelecimento Roll Festas. Atualmente a loja não contem nenhum tipo de sistema. Esse projeto foi realizado como TCC.
O sistema atual consegue tem:
- Login
###### Venda
- Nova venda
- Troca
- Devolução
- Verificar todas as vendas do dia
- Vender com pagamentos pendentes
- Aplicar desconto
- Calcula troco
###### Usuário
- Novo usuário
- Editar usuário
- Apagar usuário
- Ver todos os usuarios
###### Mercadoria
- Adicionar nova mercadoria do estoque
- Editar informações  das mercadoria
- Apagar mercadoria
- Pesquisar produto (por código, nome ou tema)
###### Encomenda
- Adicionar nova encoemnda (no dia da entrega o usuário recebe um alerta)
- Editar informações  da encoemnda
- Cancelar encoemnda
- Ver todas as encoemndas (por código, data ou tema)
###### Evento
- Cadstrar novo evento
- Editar informações  do evento
- Ver todas os eventos
###### Calcular
- Banner (* não concluido por falta de informações do cliente)
- MDF (* não concluido por falta de informações do cliente)
###### Caixa
- Registrar retirada
- Registrar depósito
- Pesquisar faturamento (dia, mês ou ano)
- Realizar fechamento de caixa
###### Ponto
- Bater ponto
- Pesuisar ponto
- Gerar e salvar planilha de ponto do mês
###### Ajuda
- Exibir tela de ajuda


##### Sobre o projeto

Projeto feito para Windows, banco de dados local.


##### Bibliotecas e tecnologias utilizadas:
- C#
- Windos Forms
- Sql Server


##### Inciar o projeto:
- Execulte o projeto no Visual Studio.
- Criar um usuário para primeiro acesso.
`INSERT INTO TB_USUARIO (nome,senha) VALUES ('admin','admin')`

##### DDL [SQL SERVER]

```sql
CREATE TABLE TB_PRODUTO
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nome] VARCHAR(30) NOT NULL, 
    [tema] VARCHAR(25)  NULL, 
    [preco] VARCHAR(7) NOT NULL, 
    [quantidade] VARCHAR(4) NULL, 
	[informar_quantidade] VARCHAR(1) NOT NULL,
    [fornecedor] VARCHAR(50) NULL, 
    [data] VARCHAR(11) NULL, 
    [descricao] NVARCHAR(150) NULL 
)

GO

CREATE TABLE TB_VENDA
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[data] VARCHAR(11) NOT NULL,
	[usuario] VARCHAR(20) NOT NULL, 
	[valortotal] VARCHAR(20) NOT NULL, 
	[valorpago] VARCHAR(20) NULL, 
	[tipopagamento] VARCHAR(20) NULL,
    [status_pagamento] VARCHAR(1) NULL,
    [valor_pendente] VARCHAR(20) NULL,
	[nome] VARCHAR(20) NULL,
)

GO

CREATE TABLE TB_PONTO
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[nome] VARCHAR(20) NOT NULL,
	[data] VARCHAR(12) NOT NULL,  
	[chegada] VARCHAR(20) NULL,
	[saida_almoco] VARCHAR(20) NULL,
	[chegada_almoco] VARCHAR(20) NULL,
	[saida] VARCHAR(20) NULL
)

GO

CREATE TABLE TB_ENCOMENDA
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[tipo_servico] VARCHAR(20) NOT NULL,
	[data_entrada] VARCHAR(11) NOT NULL, 
	[data_entrega] VARCHAR(11) NOT NULL,
	[entregue] VARCHAR(1) NOT NULL,
	[tema] VARCHAR(20) NULL, 
	[quantidade] VARCHAR(20) NULL, 
	[valor] VARCHAR(20) NOT NULL,
	[descricao] VARCHAR(100) NULL,
	[nomecliente] VARCHAR(100) NULL,
)

GO

CREATE TABLE TB_EVENTO
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[cep] VARCHAR(10) NULL,
	[local] VARCHAR(100) NOT NULL, 
	[descricao] VARCHAR(200) NOT NULL,
	[nome_cliente] VARCHAR(100) NULL,
	[telefone_1] VARCHAR(17) NULL,
	[telefone_2] VARCHAR(17) NULL,
	[email] VARCHAR(50) NULL, 
	[tipo] VARCHAR(20) NULL, 
	[data] VARCHAR(20) NULL, 
	[hora] VARCHAR(20) NULL, 
	[valor_total] VARCHAR(20) NOT NULL,
	[valor_pago] VARCHAR(20) NOT NULL,
	[entregue] VARCHAR(1) NOT NULL,
)


GO

CREATE TABLE TB_CAIXA
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[valor_total_dia] VARCHAR(20) NULL,
    [data] VARCHAR(20) NULL,
	[retirada] VARCHAR(11) NULL, 
	[deposito] VARCHAR(11) NULL,
    [dinheiro] VARCHAR(10) NULL,
	[cartao] VARCHAR(10) NULL,
	[outros] VARCHAR(10) NULL,
	[devolucao] VARCHAR(20) NULL
)

GO

CREATE TABLE TB_USUARIO
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[nome] VARCHAR(20) NOT NULL,
    [senha] VARCHAR(20) NOT NULL,
	[email] VARCHAR(30) NOT NULL,
	[data_admissao] VARCHAR(11) NOT NULL,
)

```



### Obs:
- As informações não estão sendo enviadas para nenhum local, são somente exibidas em tela.
- Pendente descobrir uma forma de pegar localização (maps) do host pelo IP

##### Iamgem 01:
![](https://i.imgur.com/LXwqdrL.jpg)

##### Iamgem 02:
![](https://i.imgur.com/kBpdYmX.jpg)

##### Iamgem 03:
![](https://i.imgur.com/kME5osM.jpg)

