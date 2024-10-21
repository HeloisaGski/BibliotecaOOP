    public class Biblioteca
    {
        public List<Livro> Livros { get; set; }
        public List<Usuario> Usuarios { get; set; }

        public Biblioteca()
        {
            Livros = new List<Livro>();
            Usuarios = new List<Usuario>();
        }

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public void EmprestarLivro(Livro livro, Usuario usuario)
        {
            if (Livros.Contains(livro) && livro.QuantidadeEmEstoque > 0)
            {
                livro.QuantidadeEmEstoque--;
                Console.WriteLine($"{livro.Titulo} foi emprestado para {usuario.Nome}.");
            }
            else
            {
                Console.WriteLine("Livro indisponível.");
            }
        }

        public void DevolverLivro(Livro livro, Usuario usuario)
        {
            if (Livros.Contains(livro))
            {
                livro.QuantidadeEmEstoque++;
                Console.WriteLine($"{livro.Titulo} foi devolvido por {usuario.Nome}.");
            }
        }

        public void MostrarLivrosDisponiveis()
        {
            Console.WriteLine("Livros disponíveis para empréstimo:");
            Console.WriteLine("-----------------------------------");
            foreach (var livro in Livros)
            {
                if (livro.QuantidadeEmEstoque>0)
                {
                    Console.WriteLine($"Título: {livro.Titulo}");
                    Console.WriteLine
                }
            }
        }
    }

