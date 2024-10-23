# Biblioteca Virtual - README

## Descrição
Este é um programa de biblioteca virtual desenvolvido em C# que utiliza os conceitos de **Programação Orientada a Objetos** (POO). O sistema permite gerenciar livros e usuários, realizar empréstimos e devoluções, bem como atualizar dados de livros e usuários. O código faz uso de conceitos fundamentais de POO, como **abstração**, **herança**, **polimorfismo**, e **encapsulamento**.

## Estrutura do Projeto
O projeto é composto por diferentes classes que representam o contexto de uma biblioteca:

- `ItemBiblioteca`: Classe abstrata que representa qualquer item disponível na biblioteca (base para `Livro`).
- `Livro`: Representa um livro na biblioteca e é um item que pode ser emprestado.
- `Usuario`: Representa um usuário da biblioteca e inclui funcionalidades para gerenciar seu histórico de empréstimos.
- Interfaces `IEmprestavel` e `IPesquisavel`: Definem comportamentos comuns para itens que podem ser emprestados e pesquisados.

## Requisitos
- **.NET SDK**: Certifique-se de ter o SDK do .NET instalado (versão 5.0 ou superior). Você pode baixar o SDK em [dotnet.microsoft.com](https://dotnet.microsoft.com/download).
- **IDE**: Recomendado usar Visual Studio, Visual Studio Code ou outra IDE que suporte C#.

## Compilar e Executar o Programa
1. **Clone o repositório**:
   
   ```sh
   git clone <URL_DO_REPOSITORIO>
   cd <PASTA_DO_PROJETO>
   ```

2. **Restaurar dependências** (se aplicável):
   
   ```sh
   dotnet restore
   ```

3. **Compilar o programa**:
   
   ```sh
   dotnet build
   ```

4. **Executar o programa**:
   
   ```sh
   dotnet run
   ```

## Como Usar o Programa
Após executar o programa, será apresentado um menu interativo no console. Você poderá selecionar uma das seguintes opções:

1. **Mostrar Livros Disponíveis**: Exibe todos os livros que estão disponíveis para empréstimo.
2. **Emprestar Livro**: Permite ao usuário informar o título do livro que deseja pegar emprestado.
3. **Devolver Livro**: Permite ao usuário devolver um livro emprestado.
4. **Atualizar Dados do Livro**: Atualiza as informações de um livro existente, incluindo título, autor e estoque.
5. **Atualizar Dados do Usuário**: Atualiza as informações de um usuário.
6. **Mostrar Usuários**: Lista todos os usuários cadastrados.
0. **Sair**: Fecha o programa.

## Exemplo de Uso
Ao rodar o programa, ele solicitará que você escolha uma das opções do menu. Você pode digitar o número correspondente à opção desejada e pressionar **Enter**. Por exemplo:

```
Escolha uma opção:
1. Mostrar Livros Disponíveis
2. Emprestar Livro
...
0. Sair
>
```

Se você escolher a opção `2` (Emprestar Livro), o programa pedirá o título do livro que você deseja emprestar. Caso o livro esteja disponível, ele será marcado como emprestado e a quantidade em estoque será reduzida.

## Conceitos de POO Aplicados
- **Herança**: A classe `Livro` herda da classe `ItemBiblioteca`, reaproveitando suas propriedades e comportamentos.
- **Encapsulamento**: A manipulação dos atributos de `Usuario` e `Livro` é feita de maneira controlada, garantindo a integridade dos dados.
- **Polimorfismo**: O método `ExibirInformacoes` é sobrescrito em `Livro` para exibir detalhes adicionais.
- **Abstração**: As classes `Livro` e `Usuario` representam os principais elementos da biblioteca, abstraindo suas funcionalidades em classes bem definidas.

## Contribuições
Contribuições são bem-vindas! Se você encontrar um bug ou desejar adicionar uma nova funcionalidade, sinta-se à vontade para abrir um **pull request** ou relatar um **issue** no repositório.

## Licença
Este projeto é distribuído sob a licença MIT. Consulte o arquivo `LICENSE` para mais detalhes.

---
Espero que este README facilite o entendimento e uso do programa! Se precisar de mais informações, fique à vontade para entrar em contato.