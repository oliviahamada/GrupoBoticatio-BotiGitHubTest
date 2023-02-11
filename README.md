# GrupoBoticario 

Esta � uma solu��o chamada GrupoBoticario, desenvolvida em .NET Framework 4.8.1 - C#.
</br>
Esta solu��o lista os reposit�rios p�blicos do GitHub. (**Teste T�cnico - BotiGitHubTest**)


*******

# Introdu��o

**OBJETIVO**: Listar os reposit�rios destaque do GitHub de cinco linguagens.
</br>
Foram selecionadas as seguintes linguagens: `GO`, `JavaScript`, `PHP`, `Python`, `Swift`.
</br>
Por se tratar de uma solu��o back-end, n�o foi focado tanto no front-end.

1. [Pesquisar no GitHub](#search)
2. [Estrutura��o](#estruturacao)
3. [Banco de Dados](#bancodados)
4. [Build](#build)
5. [Execu��o](#execution)
6. [Sobre Mim](#aboutme)

*******

<div id='search'/>

## Pesquisar no GitHub 
> **Warning**: Leia com aten��o 

A API permite realizar buscas de acordo com o filtro da requisi��o, por�m cont�m limita��es, como por exemplo, seu consumo permite retornar at� 1000 registros, sendo no m�ximo 100 registros por requisi��o.
Para mais informa��es acesse a document�o do [GitHub](https://docs.github.com/en/search-github).



*******

<div id='estruturacao'/>

## Estrutura��o 

Os arquivos est�o divididos cada um em pastas de acordo com sua fun��o (Model, View, Controller, Service, Interface, e etc...)
</br>

*******

<div id='bancodados'/>

## Banco de Dados

O banco de dados utilizado foi o SQL Server com integrado ao Microsoft Azure. O modelo do banco est� adicionado ao projeto e tamb�m na pasta '/Documenation/`.

A listas das cinco linguagens utilizadas para o filtro est�o inseridas na tabela `RepositoriesLanguages`.

> **Warning**: *Os arquivos de configura��es foram alterados. Ser� necess�rio alterar as seguintes informa��es: {ServerAddress} / {InitialCatalog} / {AdminUser} / {Password}. Arquivos: `Web.config` e `app.config`.*
</br>

*******

<div id='build'/>

## Build

Ap�s configurar o ambiente e alterar as strings de conex�o, ser� necess�rio criar o banco de dados. Para �sso, foram executadas os seguintes comandos (executar no Package Manager Console):


```
Enable-Migrations -ContextTypeName GrupoBoticatio.Context.ManagerContext -force

Add-Migration InitialCreate

Update-Database
```

Estes comandos permitem criar estruturas de tabelas que foram adicionadas ao modelo. [Migra��es do Code First](https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/migrations/)
</br>
</br>
*******

<div id='execution'/>

## Execu��o

A tela principal apresenta a lista das 5 linguagens inseridas na tabela. Selecionando o link no nome da linguagem, a aplica��o faz a requisi��o dos reposit�rios, e assim que retornar os dados, os menos s�o inseridos na tabela `RepositoriesItemsDetails`. Para mostrar o detalhe ser� necess�rio selecionar o link no nome do resposit�rio, e a aplica��o ir� fazer essa consulta no banco de dados.

> **Warning**: Por se tratar de uma grande volumetria de dados, a aplica��o faz `TRUNCATE` na tabela antes de gravar os registros, assim armazendo apenas o resultado da �ltima requisi��o.
</br>
</br>

*******

<div id='aboutme'/>

## Sobre Mim (Pendente)


###### Nome: 