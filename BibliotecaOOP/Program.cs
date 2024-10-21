 Biblioteca biblioteca = new Biblioteca();

        Livro livro1 = new Livro("Harry Potter e a Pedra Filosofal", "J.K. Rowling", "978-85-325-0043-2", "Fantasia", 15);
        Livro livro2 = new Livro("Harry Potter e a Camara Secreta", "J.K. Rowling", "978-85-325-0077-0", "Fantasia", 2);
        Livro livro3 = new Livro("Harry Potter e o Prisioneiro de Azkaban", "J.K. Rowling", "978-85-325-0081-7", "Fantasia", 5);
        Livro livro4 = new Livro("Harry Potter e o Calice de Fogo", "J.K. Rowling", "978-85-325-0088-6", "Fantasia", 10);
        Livro livro5 = new Livro("Harry Potter e a Ordem da Fenix", "J.K. Rowling", "978-85-325-0095-4", "Fantasia", 2);
        Livro livro6 = new Livro("Harry Potter e o Enigma do Principe", "J.K. Rowling", "978-85-325-0105-0", "Fantasia", 1);
        Livro livro7 = new Livro("Harry Potter e as Reliquias da Morte", "J.K. Rowling", "978-85-325-0106-7", "Fantasia", 3);

        biblioteca.AdicionarLivro(livro1);
        biblioteca.AdicionarLivro(livro2);
        biblioteca.AdicionarLivro(livro3);
        biblioteca.AdicionarLivro(livro4);
        biblioteca.AdicionarLivro(livro5);
        biblioteca.AdicionarLivro(livro6);
        biblioteca.AdicionarLivro(livro7);

        Usuario usuario1 = new Usuario("Heloisa", 1, "Rua D, 123", "9999-8888");
        Usuario usuario2 = new Usuario("Sabrina", 2, "Rua C, 456", "9999-7777");
        Usuario usuario3 = new Usuario("Andry", 3, "Rua B, 123", "9999-6666");
        Usuario usuario4 = new Usuario("Kailan", 4, "Rua M, 456", "9999-5555");
        Usuario usuario5 = new Usuario("Maria Clara", 5, "Rua L, 123", "9999-4444");
        Usuario usuario6 = new Usuario("Luiza", 6, "Rua Z, 456", "9999-3333");
        Usuario usuario7 = new Usuario("Raissa", 7, "Rua H, 123", "9999-2222");
        Usuario usuario8 = new Usuario("Julian", 8, "Rua G, 456", "9999-1111");

        biblioteca.AdicionarUsuario(usuario1);
        biblioteca.AdicionarUsuario(usuario2);
        biblioteca.AdicionarUsuario(usuario3);
        biblioteca.AdicionarUsuario(usuario4);
        biblioteca.AdicionarUsuario(usuario5);
        biblioteca.AdicionarUsuario(usuario6);
        biblioteca.AdicionarUsuario(usuario7);
        biblioteca.AdicionarUsuario(usuario8);

        int opcao = 0;
        do
        {
            Console.WriteLine("\n--- Menu da Biblioteca ---");
            Console.WriteLine("1. Mostrar livros disponíveis para empréstimo");
            Console.WriteLine("2. Emprestar um livro");
            Console.WriteLine("3. Devolver um livro");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            
            // Prevenir nulos
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out opcao))
            {
                Console.WriteLine("Opção inválida.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    biblioteca.MostrarLivrosDisponiveis();
                    break;

                case 2:
                    Console.WriteLine("Digite o nome do livro para emprestar:");
                    string? tituloEmprestar = Console.ReadLine();

                    if (tituloEmprestar != null)
                    {
                        Livro? livroEmprestar = biblioteca.BuscarLivroPorTitulo(tituloEmprestar);

                        if (livroEmprestar != null)
                        {
                            biblioteca.EmprestarLivro(livroEmprestar, usuario1);
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado.");
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("Digite o nome do livro para devolver:");
                    string? tituloDevolver = Console.ReadLine();

                    if (tituloDevolver != null)
                    {
                        Livro? livroDevolver = biblioteca.BuscarLivroPorTitulo(tituloDevolver);

                        if (livroDevolver != null)
                        {
                            biblioteca.DevolverLivro(livroDevolver, usuario1);
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado.");
                        }
                    }
                    break;

                case 0:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != 0);
    