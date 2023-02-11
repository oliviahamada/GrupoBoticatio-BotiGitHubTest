# GrupoBoticario 

Esta é uma solução chamada GrupoBoticario, desenvolvida em .NET Framework 4.8.1 - C#.
</br>
Esta solução lista os repositórios públicos do GitHub. (**Teste Técnico - BotiGitHubTest**)


*******

# Introdução

**OBJETIVO**: Listar os repositórios destaque do GitHub de cinco linguagens.
</br>
Foram selecionadas as seguintes linguagens: `GO`, `JavaScript`, `PHP`, `Python`, `Swift`.
</br>
Por se tratar de uma solução back-end, não foi focado tanto no front-end.

1. [Pesquisar no GitHub](#search)
2. [Estruturação](#estruturacao)
3. [Banco de Dados](#bancodados)
4. [Build](#build)
5. [Execução](#execution)
6. [Sobre Mim](#aboutme)

*******

<div id='search'/>

## Pesquisar no GitHub 
> **Warning**: Leia com atenção 

A API permite realizar buscas de acordo com o filtro da requisição, porém contém limitações, como por exemplo, seu consumo permite retornar até 1000 registros, sendo no máximo 100 registros por requisição.
Para mais informações acesse a documentão do [GitHub](https://docs.github.com/en/search-github).



*******

<div id='estruturacao'/>

## Estruturação 

Os arquivos estão divididos cada um em pastas de acordo com sua função (Model, View, Controller, Service, Interface, e etc...)
</br>

*******

<div id='bancodados'/>

## Banco de Dados

O banco de dados utilizado foi o SQL Server com integrado ao Microsoft Azure. O modelo do banco está adicionado ao projeto e também na pasta '/Documenation/`.

A listas das cinco linguagens utilizadas para o filtro estão inseridas na tabela `RepositoriesLanguages`.

> **Warning**: *Os arquivos de configurações foram alterados. Será necessário alterar as seguintes informações: {ServerAddress} / {InitialCatalog} / {AdminUser} / {Password}. Arquivos: `Web.config` e `app.config`.*
</br>

*******

<div id='build'/>

## Build

Após configurar o ambiente e alterar as strings de conexão, será necessário criar o banco de dados. Para ísso, foram executadas os seguintes comandos (executar no Package Manager Console):


```
Enable-Migrations -ContextTypeName GrupoBoticatio.Context.ManagerContext -force

Add-Migration InitialCreate

Update-Database
```

Estes comandos permitem criar estruturas de tabelas que foram adicionadas ao modelo. [Migrações do Code First](https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/migrations/)
</br>
</br>
*******

<div id='execution'/>

## Execução

A tela principal apresenta a lista das 5 linguagens inseridas na tabela. Selecionando o link no nome da linguagem, a aplicação faz a requisição dos repositórios, e assim que retornar os dados, os menos são inseridos na tabela `RepositoriesItemsDetails`. Para mostrar o detalhe será necessário selecionar o link no nome do respositório, e a aplicação irá fazer essa consulta no banco de dados.

> **Warning**: Por se tratar de uma grande volumetria de dados, a aplicação faz `TRUNCATE` na tabela antes de gravar os registros, assim armazendo apenas o resultado da última requisição.
</br>
</br>

*******

<div id='aboutme'/>

## Sobre Mim (Pendente)


###### Nome: 