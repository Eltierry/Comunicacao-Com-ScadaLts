# Comunicação com o banco de dados do Supervisório ScadaLts

## Sobre o projeto
Comunicação com o supervisório ScadaLts. 
Utilizando a engenharia reversa e com o auxílio do Entity Framework, é possível obter em formato de classes toda a estrutura do banco de dados.

## Documentação e fonte de pesquisa
* Microsoft: [Scaffolding EngenhariaReversa](https://learn.microsoft.com/pt-br/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli) 
* Microsoft: [Code First to an Existing Database](https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database) 
* Microsoft: [Entity Framework Core tools reference - .NET Core CLI](https://learn.microsoft.com/en-us/ef/core/cli/dotnet) 

## Tecnologias utilizadas
### Back end
- C#
### Banco de dados
- MySql
## Pré-requisitos
[.Net 6.0](https://dotnet.microsoft.com/pt-br/download/dotnet/6.0).

## Criar projeto
```Csharp
dotnet new console -n <NomeDoProjeto> -f net6.0
```
## Ferramentas necessárias

```Csharp
// Entity Framework
dotnet tool install --global dotnet-ef

// Framework para trabalhar com MySql
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 6.0.0

// Pacote Design do Entity Framework
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.0
```
## Trazer o banco em formato de classes (Engenharia Reversa)
Observação: O ScadaLts está na máquina local (localhost). 
Padrão: Porta 3308 e sem senha.
```csharp
dotnet ef dbcontext scaffold "server=localhost;port=3308;userid=root;password=;database=scadalts" Pomelo.EntityFrameworkCore.MySql -o Models/ScadaLtsClass
```
## Sugestão

Crie uma pasta "Context".
Dentro da pasta "Models/ScadaLtsClass" tem um arquivo chamado "scadaltsContext.cs". Mova-o para a para a pasta "Context".

## Opcional
Ao optar pela sugestão acima, o Namespace permanecerá como (<NomeDoProjeto>.Models.ScadaLtsClass). Caso queira deixar no Namespace "<NomeDoProjeto>.Context", terá que fazer o import (using <NomeDoProjeto>.Models.ScadaLtsClass;).
Nesse projeto não foi feito isso.

## Como executar a aplicação
Digitar o comando no terminal:
```
dotnet run
```


## Telas
### Resultado
 10 resultados filtrados por ID de forma crescente
```
ID: 1    DataPoint: 4    DataType: 1     Pointalue: 0      Ts:1687416639443
ID: 2    DataPoint: 1    DataType: 3     Pointalue: 6822      Ts:1687416639443
ID: 3    DataPoint: 2    DataType: 3     Pointalue: 7121      Ts:1687416639443
ID: 4    DataPoint: 3    DataType: 1     Pointalue: 1      Ts:1687416639443
ID: 5    DataPoint: 1    DataType: 3     Pointalue: 6823      Ts:1687416640443
ID: 6    DataPoint: 2    DataType: 3     Pointalue: 7122      Ts:1687416640443
ID: 7    DataPoint: 8    DataType: 1     Pointalue: 0      Ts:1687416762326
ID: 8    DataPoint: 5    DataType: 3     Pointalue: 5450      Ts:1687416762326
ID: 9    DataPoint: 6    DataType: 3     Pointalue: 0      Ts:1687416762326
ID: 10   DataPoint: 7    DataType: 1     Pointalue: 1      Ts:1687416762326
```



## Agradecimentos
[Professor Nélio Alves](https://www.linkedin.com/in/nelio-alves/) 

## Contribuição
Os pull requests são bem-vindos. Para mudanças importantes, abra um problema primeiro para discutir o que você gostaria de mudar.
Certifique-se de atualizar os testes conforme apropriado.

## License
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/Eltierry/Comunicacao-Com-ScadaLts/blob/main/LICENSE)