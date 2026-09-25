# 🎵 Scream Sound

Projeto de console desenvolvido em **C#** com **.NET 10**, criado para praticar conceitos básicos de programação e desenvolvimento de aplicações em linha de comando.

O **Scream Sound** permite cadastrar bandas, visualizar as bandas registradas, adicionar avaliações e consultar a média das notas de cada banda.

## 📋 Funcionalidades

- 🎸 Registrar novas bandas.
- 📃 Listar todas as bandas cadastradas.
- ⭐ Avaliar uma banda com uma nota.
- 📊 Consultar a média das avaliações de uma banda.
- 🚪 Encerrar o programa pelo menu principal.

## 🛠️ Tecnologias utilizadas

- **C#**
- **.NET 10.0.401**
- Aplicação de **console**
- Visual Studio Code

## 🧠 Conceitos praticados

Este projeto utiliza alguns conceitos importantes de C# e lógica de programação:

- Variáveis e tipos de dados
- Métodos
- Estruturas condicionais (`if/else`)
- Estrutura de repetição (`while`)
- `switch/case`
- `Dictionary<TKey, TValue>`
- `List<T>`
- Entrada e saída de dados com `Console.ReadLine()` e `Console.WriteLine()`
- Conversão e validação de dados com `int.TryParse()`
- Interpolação de strings
- LINQ, incluindo `Average()` e `FirstOrDefault()`

## 📁 Estrutura do projeto

```text
Projeto musical/
├── bin/
├── obj/
├── Program.cs
├── Projeto musical.csproj
├── .gitignore
└── README.md
```

## ▶️ Como executar

### Pré-requisitos

Tenha o **.NET SDK 10** instalado.

Para verificar a versão instalada:

```bash
 dotnet --version
```

O resultado esperado para este projeto é:

```text
10.0.401
```

### Executando o projeto

No terminal, dentro da pasta do projeto, execute:

```bash
dotnet run
```

O programa apresentará o menu principal:

```text
Digite 1 para registrar uma banda
Digite 2 para mostrar todas as bandas
Digite 3 para avaliar uma banda
Digite 4 para exibir a média de uma banda
Digite -1 para sair
```

## 🎮 Exemplo de uso

Ao iniciar o programa, algumas bandas já estão cadastradas para teste.

Por exemplo, para avaliar **Linkin Park**:

```text
Digite a sua opção: 3

Digite o nome da banda que deseja avaliar: Linkin Park
Qual a nota fornecida para a banda Linkin Park: 9

Nota 9 registrada com sucesso para a banda Linkin Park!
```

Depois, ao consultar a média:

```text
Digite a sua opção: 4

Digite o nome da banda que deseja ver a média das avaliações: Linkin Park

A média da banda Linkin Park é: 8.25
```

## 💾 Dados cadastrados

Atualmente, os dados são armazenados **em memória** utilizando um `Dictionary<string, List<int>>`.

Isso significa que as bandas e avaliações são perdidas quando o programa é encerrado. O projeto não utiliza banco de dados ou arquivos para persistência.

## 🚀 Possíveis melhorias futuras

Algumas funcionalidades que podem ser adicionadas posteriormente:

- Remover bandas cadastradas.
- Alterar ou excluir avaliações.
- Exibir a maior e a menor nota de uma banda.
- Criar uma tela para detalhes de cada banda.
- Persistir os dados em arquivo ou banco de dados.
- Melhorar a validação das notas.
- Adicionar novas opções ao menu.

## 👨‍💻 Projeto

Projeto desenvolvido como exercício de aprendizado em **C# e .NET**, com foco em estruturas de dados, métodos, controle de fluxo e interação com o usuário pelo terminal.
