# GTI_Challenge
Entrega do teste para a GTI Solution

### Features

- [x] API Rest (Get, Post, Put, Delete)
- [x] Web Application MVC
- [x] Serviço WCF
- [x] Web Form CRUD

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:

- Visual Studio
- SQL Server Management Studio

Crie um banco de dados com o nome "GTI_DB" no SQL Server e execute o código do arquivo https://github.com/taparosky/GTI_Challenge/blob/master/CreateTable.sql para
criar a tabela "Clientes".

Após fazer o download de todos arquivos deste repositório, abra o arquivo "WebApplication.Solution.sln".

Você precisará alterar as seguintes configurações para executar a solução em sua máquina:

1. Acessar o arquivo appsettings.json dentro do projeto "WebRestAPI" e substituir a Connection String pelos valores da máquina em que está sendo testada a solução.
2. Acessar o arquivo ClienteController.cs no projeto "WebAppMVC" e alterar a linha 12, substituindo o link de conexão à API pelo link correspondente de sua máquia.
3. Acessar o arquivo Service1.svc.cs no projeto "WcfServiceApp" e alterar a connection string na linha 17.

Para testar a aplicação MVC, selecione os projetos "WebRestAPI" e  "WebAppMVC" para inicializarem. Para testar o Web Form, selecione os projetos "WebFormsApp" e 
"WcfServiceApp" para inicializarem.

### 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

- [.NET 6.0]
- [C#]
- [Visual Studio]
- [WCF]
- [Web Forms]
- [API Rest]

### Autor
---


 <img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/55306962?v=4" width="100px;" alt=""/>
 Vinicius Taparosky
(https://www.linkedin.com/in/vinicius-taparosky/) 
