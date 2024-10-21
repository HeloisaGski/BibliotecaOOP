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
        if (!Livros.Contains(livro) || livro.QuantidadeEmEstoque <= 0)
    {
        Console.WriteLine("Livro indisponível.");
        return;
    }
    Console.WriteLine("Escolha o usuário para o empréstimo:");
    for (int i = 0; i < Usuarios.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {Usuarios[i].Nome}");
    }
    int escolhaUsuario;
    do
    {
        Console.Write("Digite o número do usuário: ");
        escolhaUsuario = int.Parse(Console.ReadLine() ?? "0");
    } while (escolhaUsuario < 1 || escolhaUsuario > Usuarios.Count);

        Usuario usuarioEscolhido = Usuarios[escolhaUsuario - 1];

        livro.QuantidadeEmEstoque--;
    Console.WriteLine($"{livro.Titulo} foi emprestado para {usuarioEscolhido.Nome}.");

    }

    public void DevolverLivro(Livro livro, Usuario usuario)
    {
        if (Livros.Contains(livro))
        {
            livro.QuantidadeEmEstoque++;
            Console.WriteLine($"{livro.Titulo} foi devolvido por {usuario.Nome}.");
        }
    }

    public Livro? BuscarLivroPorTitulo(string titulo)
{
    return Livros.FirstOrDefault(l => l.Titulo.Trim().Equals(titulo.Trim(), StringComparison.OrdinalIgnoreCase));
}


    public void MostrarLivrosDisponiveis()
    {
        Console.WriteLine("Livros disponíveis para empréstimo:");
        Console.WriteLine("-----------------------------------");
        foreach (var livro in Livros)
        {
            if (livro.QuantidadeEmEstoque > 0)
            {
                Console.WriteLine($"Título: {livro.Titulo}");
                Console.WriteLine($"Autor: {livro.Autor}");
                Console.WriteLine($"ISBN: {livro.Isbn}");
                Console.WriteLine($"Gênero: {livro.Genero}");
                Console.WriteLine($"Quantidade em estoque: {livro.QuantidadeEmEstoque}");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
