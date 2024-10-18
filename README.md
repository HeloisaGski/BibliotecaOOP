# # Sistema de Gerenciamento de Biblioteca

Este é um sistema simples de gerenciamento de biblioteca desenvolvido em C#. O sistema permite o cadastro de livros e usuários, além de permitir o empréstimo e devolução de livros.

## Funcionalidades

- **Cadastro de Livros:** Adicione novos livros ao sistema com informações como título, autor, ISBN, gênero e quantidade em estoque.
- **Cadastro de Usuários:** Adicione usuários que podem pegar livros emprestados.
- **Empréstimo de Livros:** Permite que usuários peguem livros emprestados, verificando se o livro está disponível.
- **Devolução de Livros:** Permite que usuários devolvam livros, atualizando a quantidade em estoque.
- **Pesquisa de Livros:** Pesquise livros por título, autor ou gênero.

## Estrutura do Projeto

O projeto é dividido nas seguintes classes principais:

- `Livro`: Representa um livro na biblioteca.
- `Usuario`: Representa um usuário do sistema.
- `Biblioteca`: Gerencia a lista de livros e usuários, além de controlar o empréstimo e devolução de livros.
- `UsuarioRepositorio`: Interface para gerenciar usuários.

## Pré-requisitos

Para executar este projeto, você precisa ter o seguinte instalado:

- [.NET SDK](https://dotnet.microsoft.com/download) (versão X.X ou superior)
- [Visual Studio](https://visualstudio.microsoft.com/) ou qualquer outro editor de texto de sua escolha.

## Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/seuusuario/seurepositorio.git
   cd seurepositorio

 
Exemplos de Uso
Após executar o programa, você pode:

Adicionar livros e usuários ao sistema.
Emprestar livros disponíveis.
Devolver livros emprestados.
Verificar a lista de livros disponíveis e seus status.
Contribuição
Sinta-se à vontade para fazer um fork deste repositório e enviar pull requests com melhorias ou correções!

Licença
Este projeto está licenciado sob a MIT License.