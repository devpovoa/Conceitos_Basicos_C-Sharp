# 📌 O que é C# e .NET?

**C#** (pronuncia-se "C sharp") é uma linguagem de programação criada pela Microsoft, inicialmente como o projeto **COOL** (_C-Like Object Oriented Language_). Desenvolvida sob a liderança do engenheiro **Anders Hejlsberg**, C# foi projetada para ser moderna, segura e orientada a objetos, incorporando aprendizados e melhorias sobre linguagens existentes.

**.NET** é a plataforma de desenvolvimento da Microsoft que fornece um ambiente robusto e unificado para a criação e execução de aplicações em diversas linguagens. Ela disponibiliza um conjunto compartilhado de bibliotecas, APIs e ferramentas que promovem reutilização de código e produtividade.

* * *

🧩 Estrutura da Plataforma .NET
-------------------------------

1. **CLR (Common Language Runtime):**  
   É a "máquina virtual" da plataforma .NET. Ela executa o código compilado, gerencia memória, segurança, threads e exceções, além de fornecer serviços essenciais para qualquer linguagem suportada, como C#, VB.NET e F#.

2. **CIL (Common Intermediate Language):**  
   É o código intermediário gerado pelo compilador C#. O CLR executa o CIL e converte para instruções nativas do sistema operacional, conforme necessário.

3. **CLI (Common Language Infrastructure):**  
   É o padrão que define a execução de código escrito para a plataforma .NET. Abrange o CLR, o CIL e a biblioteca de tipos básicos. É um conjunto de regras que garante interoperabilidade entre diferentes linguagens na plataforma.

* * *

🧮 Variáveis e Tipos Primitivos
-------------------------------

Todo tipo primitivo em C# é baseado em uma quantidade específica de bytes. Lembre-se: **1 byte = 8 bits**, com até 256 combinações possíveis.

| Tipo      | Tamanho  | Faixa de Valores                                       | Observações                    |
| --------- | -------- | ------------------------------------------------------ | ------------------------------ |
| `bool`    | 1 byte   | `true`, `false`                                        | Representa verdadeiro ou falso |
| `byte`    | 1 byte   | 0 a 255                                                | Somente valores positivos      |
| `sbyte`   | 1 byte   | -128 a 127                                             | Com sinal                      |
| `short`   | 2 bytes  | -32.768 a 32.767                                       |                                |
| `ushort`  | 2 bytes  | 0 a 65.535                                             |                                |
| `int`     | 4 bytes  | -2.147.483.648 a 2.147.483.647                         | Tipo mais usado para inteiros  |
| `uint`    | 4 bytes  | 0 a 4.294.967.295                                      | Somente positivos              |
| `long`    | 8 bytes  | -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 | Valores grandes                |
| `ulong`   | 8 bytes  | 0 a 18.446.744.073.709.551.615                         |                                |
| `float`   | 4 bytes  | Até 10³⁸, precisão simples                             | Ex: `10.9f`                    |
| `double`  | 8 bytes  | Até 10³⁰⁸, precisão dupla                              | Ex: `10.0`                     |
| `decimal` | 16 bytes | Até 28 casas decimais                                  | Ex: `10.991m`                  |
| `char`    | 2 bytes  | Um único caractere Unicode                             | Ex: `'a'`, `'ç'`, `'1'`        |

Esses são conhecidos como **tipos primitivos** ou **value types**.

### 🔁 Casting

Conversão explícita de tipos:
    int valor = 1;
    short valorPequeno = (short)valor;

* * *

🔄 Estruturas de Controle
-------------------------

### `if`, `else`

    if (condicao) {
        // código
    } else {
        // outro código
    }

### Operadores de Comparação

* `<` menor que

* `>` maior que

* `==` igual a

* `!=` diferente de

* `<=` menor ou igual a

* `>=` maior ou igual a

* `!` negação

### Operadores Lógicos

* `&&` (E lógico) – ambas as condições devem ser verdadeiras

* `||` (OU lógico) – pelo menos uma condição deve ser verdadeira

* * *

🔁 Estruturas de Repetição
--------------------------

### `for`

    for (int i = 0; i < 10; i++) {
        Console.WriteLine(i);
    }

* * *

🧱 Classes e Objetos
--------------------

Uma **classe** define a estrutura de um objeto. O nome do arquivo geralmente corresponde ao nome da classe:
    class Conta {
        public int Numero;
        public string Titular;
        public decimal Saldo;
    }

Para **instanciar**:
    Conta c = new Conta();

Usar `new` aloca memória para o objeto e retorna uma referência para ele.

### 🔒 Valores Padrão de Atributos

* Tipos numéricos → `0`

* `bool` → `false`

* Referências → `null`

* * *

🧠 Convenções de Nomenclatura em C#
-----------------------------------

| Elemento         | Convenção           | Exemplo                         |
| ---------------- | ------------------- | ------------------------------- |
| Classe, Método   | PascalCase          | `ContaBancaria`, `SacarValor()` |
| Propriedade      | PascalCase          | `SaldoAtual`                    |
| Interface        | `I` + PascalCase    | `IConta`                        |
| Namespace        | PascalCase          | `MeuApp.Models`                 |
| Parâmetro        | camelCase           | `decimal valor`                 |
| Variável local   | camelCase           | `decimal novoSaldo`             |
| Atributo privado | `_camelCase`        | `_saldoAtual`                   |
| Atributo público | PascalCase          | `public int Numero;`            |
| Constante        | PascalCase ou UPPER | `TaxaJuros`, `PI`               |

* * *

🤝 Composição de Classes
------------------------

Uma classe pode usar outras classes como atributos:
    class Conta {
        public Cliente TitularConta = new Cliente();
    }

* * *

🔐 Encapsulamento e Modificadores de Acesso
-------------------------------------------

| Modificador          | Acesso permitido em...                       |
| -------------------- | -------------------------------------------- |
| `public`             | Qualquer lugar                               |
| `private`            | Somente dentro da mesma classe               |
| `protected`          | Na classe ou em derivadas                    |
| `internal`           | Dentro do mesmo assembly                     |
| `protected internal` | No mesmo assembly ou em derivadas            |
| `private protected`  | Na classe ou derivadas **no mesmo assembly** |

> Boas práticas recomendam que atributos sejam privados e acessados por meio de **properties**.

### 🧩 Properties

Controlam leitura e escrita:
    private decimal saldo;
    public decimal Saldo {
        get { return saldo; }
        set { saldo = value; }
    }

### Auto-Implemented Properties

Simplificam a declaração:
    public int Numero { get; set; }
    public string Nome { get; private set; }

* * *

🌐 Visibilidade `internal`
--------------------------

Por padrão, classes têm visibilidade **internal**, ou seja, visíveis apenas dentro do projeto (assembly). Para expor classes em bibliotecas externas (DLLs), declare como `public`.

* * *

🏗️ Construtores
----------------

Usados para inicializar objetos:
    public Cliente() { }
    public Cliente(string nome, string cpf) {
        Nome = nome;
        Cpf = cpf;
    }

### Por que usar construtores?

1. Garante objetos válidos desde o início

2. Evita atribuições espalhadas

3. Permite lógica de validação

* * *

🧰 Parâmetros em Métodos
------------------------

### 1. Parâmetros Opcionais

    void EnviarMensagem(string texto, string destinatario = "Usuário") {
        Console.WriteLine($"Mensagem para {destinatario}: {texto}");
    }

### 2. Parâmetros Nomeados

    RegistrarUsuario(nome: "Ana", cidade: "BH", idade: 25);

### 3. Combinando ambos

    CriarConta("Thiago");
    CriarConta("João", saldoInicial: 500);
    CriarConta("Maria", tipo: "Poupança");

* * *

🚀 Object Initializer
---------------------

Facilita a criação de objetos sem múltiplas linhas:
    var cliente = new Cliente {
        Nome = "Thiago",
        Idade = 38
    };

Muito útil com **DTOs** (Data Transfer Objects) em APIs, formulários, serviços e serialização.

---

## 📬 Contato

Caso tenha dúvidas ou queira trocar conhecimento, entre em contato:

- 📧 Email: <thiagopovoadev@hotmail.com>
- 🌐 [Portfólio](https://devpovoa.github.io/My_Portfolio_Web/)
- 💼 [LinkedIn](https://www.linkedin.com/in/thiago-povoa-dev)

---

## 🏆 Contribuições

Contribuições são bem-vindas! Caso queira adicionar soluções, novos desafios ou melhorias:

1. 🍴 Faça um **fork** do repositório.

2. 🌿 Crie uma nova branch:
   
   ```bash
   git checkout -b minha-contribuicao
   ```

3. 📝 Adicione suas alterações e faça um commit:
   
   ```bash
   git commit -m "Descrição das alterações"
   ```

4. 📤 Envie as alterações para o seu fork:
   
   ```bash
   git push origin minha-contribuicao
   ```

5. 🔀 Abra um **pull request** neste repositório.

## 🖋️ Licença

Este repositório é destinado a fins educacionais e não possui qualquer relação oficial com o autor ou a editora do livro. O conteúdo aqui desenvolvido é baseado no aprendizado extraído do material, respeitando os direitos autorais.

Este projeto está sob a licença [MIT](LICENSE).

---

🚀 Repositório criado e produzido por © DevPovoa 🎯


