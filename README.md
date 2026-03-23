# Sistema de Transporte Aéreo — SOLID + Factory Method em C#

Descrição
------------
Aplicação prática desenvolvida em C# com foco na refatoração de código aplicando os cinco princípios SOLID e o padrão criacional Factory Method.  
O sistema simula operações de transporte aéreo com diferentes tipos de aviões: Cargueiro, Passageiro e Militar, incluindo cálculo de tempo estimado de voo.

------------------------------------------------------------

Sobre o Projeto
-----------------
Este projeto foi desenvolvido como parte do TDE da disciplina de Padrões de Projeto de Software.  

O objetivo é demonstrar, na prática, como a aplicação dos princípios SOLID combinada com o padrão Factory Method melhora a organização, flexibilidade e manutenção do código.

------------------------------------------------------------

Arquitetura / Estrutura
-------------------------
SistemaAereo/
│
├── IAviao.cs           → Interface (contrato para todos os aviões)
├── AviaoCargueiro.cs   → Implementação de avião cargueiro
├── AviaoPassageiro.cs  → Implementação de avião de passageiros
├── AviaoMilitar.cs     → Implementação de avião militar
├── AviaoFactory.cs     → Factory Method (criação dos objetos)
├── Configuracao.cs     → Singleton (configurações globais)
└── Program.cs          → Interação com o usuário

------------------------------------------------------------

Problema Sem Uso de SOLID
----------------------------
Sem a aplicação dos princípios SOLID e padrões de projeto, o sistema apresentaria:

- Alto acoplamento (uso direto de "new")
- Dificuldade de manutenção
- Código rígido (difícil de expandir)
- Violação do princípio Open/Closed
- Duplicação de lógica

Isso tornaria o sistema difícil de evoluir e propenso a erros.

------------------------------------------------------------

Princípios SOLID Aplicados
----------------------------

S – Single Responsibility:
Cada classe possui uma única responsabilidade:
- Classes de avião → transporte
- Factory → criação de objetos
- Configuração → dados globais

O – Open/Closed:
O sistema está aberto para extensão e fechado para modificação.

Para adicionar um novo tipo de avião:
- Criar nova classe
- Implementar IAviao
- Ajustar a fábrica

L – Liskov Substitution:
Qualquer classe que implementa IAviao pode substituir outra sem quebrar o sistema.

I – Interface Segregation:
A interface IAviao contém apenas o necessário:
void Transportar(string tipo, int quantidade);

D – Dependency Inversion:
O sistema depende de abstrações (IAviao), e não de implementações concretas.

------------------------------------------------------------

Factory Method
----------------
O padrão Factory Method foi aplicado na classe AviaoFactory, responsável por encapsular a criação dos objetos.

Exemplo:

IAviao aviao = AviaoFactory.CriarAviao("cargueiro");
aviao.Transportar("Carga pesada", 150);

Benefícios:

- Baixo acoplamento
- Centralização da criação de objetos
- Facilidade de manutenção
- Facilidade de expansão

------------------------------------------------------------

Como Executar
----------------
Pré-requisitos:
- .NET SDK 6.0 ou superior

Passos:

git clone https://github.com/rikelmyaguiar/TDE-PADROES-DE-PROJETO-DE-SOFTWARE.git

cd TDE-PADROES-DE-PROJETO-DE-SOFTWARE

dotnet run

------------------------------------------------------------

Exemplo de Execução
--------------------

=== Sistema de Transporte Aéreo ===

Tipos disponíveis:
1 - Cargueiro
2 - Passageiro
3 - Militar

Escolha o tipo de avião:
1

Peso da carga? (1 - leve, 2 - pesada, 3 - muito pesada)
2

Quantidade:
500

Transportando 500 unidades no avião CARGUEIRO
Tempo estimado: 1.0 horas

------------------------------------------------------------

Tecnologias
---------------

- C#
- .NET 6+

------------------------------------------------------------

Autor
------------

Adriano Rikelmy Aguiar da Silva - 5° Período  
TDE de Padrões de Projeto de Software - Professor: Marcos Gomes da Silva Rocha
