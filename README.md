Sistema de Transporte Aéreo — SOLID + Factory Method em C# 

Descrição
------------
Aplicação prática desenvolvida em C# com foco na refatoração de código aplicando os cinco princípios SOLID e o padrão criacional Factory Method.  
Simula um sistema de transporte aéreo com diferentes tipos de aviões: Cargueiro, Passageiro e Militar, com cálculo de tempo estimado de voo.

---

Sobre o Projeto
-----------------
Este projeto faz parte de uma atividade de TDE da disciplina de Programação para Banco de Dados e Padrões de Projeto de Software.  
Objetivo: demonstrar como os princípios SOLID + Factory Method tornam o código mais organizado, flexível e manutenível.

---

Arquitetura / Estrutura
-------------------------
SistemaAereo/
│
├── IAviao.cs           → Interface de contrato para todos os aviões
├── AviaoCargueiro.cs   → Implementação de avião cargueiro
├── AviaoPassageiro.cs  → Implementação de avião de passageiros
├── AviaoMilitar.cs     → Implementação de avião militar
├── AviaoFactory.cs     → Factory Method — cria os aviões conforme tipo
├── Configuracao.cs     → Singleton — guarda configurações globais
└── Program.cs          → Interação com o usuário (console)

---

Princípios SOLID Aplicados
----------------------------
S – Single Responsibility:
  Cada classe tem responsabilidade única (interface, transporte, configuração)

O – Open/Closed:
  Adicionar novos tipos de avião exige apenas criar uma nova classe, sem alterar as existentes

L – Liskov Substitution:
  O código cliente depende da interface IAviao, qualquer avião pode ser substituído sem quebrar o fluxo

I – Interface Segregation:
  IAviao contém apenas o método necessário para transporte, evitando métodos desnecessários

D – Dependency Inversion:
  O código principal depende de abstrações (IAviao), não de implementações concretas

---

Factory Method
----------------
Classe AviaoFactory encapsula toda a criação de objetos:

IAviao aviao = AviaoFactory.CriarAviao("cargueiro");
aviao.Transportar("Carga pesada", 150);


O código cliente **não usa `new` diretamente**, garantindo baixo acoplamento.

---

Como Executar
----------------
Pré-requisitos:
- .NET SDK 6.0+

Passos:

1️ Clone o repositório
   git clone https://github.com/rikelmyaguiar/TDE-PADROES-DE-PROJETO-DE-SOFTWARE.git

2️ Acesse a pasta do projeto
   cd TRANSPORTE-AEREO

3️ Execute o projeto
   dotnet run

---

Saída Esperada
-----------------
Exemplo de execução:

=== Sistema de Transporte Aéreo - Logistica Aérea XYZ ===
Tipos de avião disponíveis: Cargueiro, Passageiro, Militar
Digite o tipo de avião que deseja usar:
cargueiro
Peso da carga? (1 - leve, 2 - pesada, 3 - muito pesada)
2
Digite a quantidade de cargas:
500
Transportando 500 unidades de 'Carga nível 2' no avião CARGUEIRO.
Tempo estimado de transporte: 1.0 horas
Operação finalizada. Pressione qualquer tecla para sair...


---

Tecnologias
---------------
- C#  
- .NET 6+

---

Autor
------------
Adriano Rikelmy Aguiar da Silva - 5° Período TDE Padrões de Projeto de Software — Professor: Marcos Gomes da Silva Rocha