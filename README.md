# InfNet.OO

Projeto de exemplo para gestão de equipes, funcionários e transferências entre equipes, utilizando conceitos de orientação a objetos em .NET 8.

## Descrição

O projeto simula um ambiente corporativo onde é possível:
- Gerenciar equipes e seus respectivos gerentes.
- Adicionar e remover funcionários das equipes.
- Realizar transferências de funcionários entre equipes, atualizando corretamente os dados de origem e destino.

## Estrutura do Projeto

- **InfNet.OO.Domain**: Contém as entidades principais (`Equipe`, `Funcionario`, `Gerente`, `Tecnico`) e regras de negócio.
- **InfNet.OO.Domain.Service**: Serviços de domínio, como a lógica de transferência de funcionários.
- **InfNet.OO.Application**: Camada de aplicação, orquestrando operações de alto nível, como a transferência entre equipes.
- **InfNet.OO.Test**: Testes unitários para garantir o correto funcionamento das regras de negócio.

## Principais Funcionalidades

- Adição e remoção de funcionários em equipes.
- Cálculo de bônus salarial para gerentes baseado no tamanho da equipe.
- Transferência de funcionários entre equipes, com atualização automática do tamanho da equipe e validações.

## Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Como Executar

1. Clone o repositório:
   git clone https://github.com/seu-usuario/InfNet.OO.git cd InfNet.OO

2. Restaure os pacotes:

3. Execute os testes:


## Estrutura de Classes

- `Equipe`: Representa uma equipe, contendo funcionários e um gerente.
- `Funcionario`: Representa um funcionário comum.
- `Tecnico`: Herda de `Funcionario` e possui lógica de bônus baseada na comissão.
- `Gerente`: Herda de `Funcionario` e possui lógica de bônus baseada no tamanho da equipe.
- `TransferenciaService`: Serviço responsável por transferir funcionários entre equipes.
- `TransferenciaEntreEquipes`: Orquestra a transferência utilizando repositórios e serviços.

## Testes

Os testes unitários estão localizados no projeto `InfNet.OO.Test` e cobrem os principais cenários de negócio, como transferência de funcionários e cálculo de bônus.

## Licença

Este projeto está licenciado sob a licença MIT.
