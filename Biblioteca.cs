public class Biblioteca : IPesquisavel
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
        Console.WriteLine($"Livro '{livro.Titulo}' adicionado com sucesso.");
    }

    public void AdicionarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
        Console.WriteLine($"Usuário '{usuario.Nome}' adicionado com sucesso.");
    }

    public void EmprestarLivro(Livro livro, Usuario usuario)
    {
        if (!Livros.Contains(livro) || livro.QuantidadeEmEstoque <= 0)
        {
            Console.WriteLine("Livro indisponível.");
            return;
        }
        livro.Emprestar(usuario);
        Console.WriteLine($"{livro.Titulo} foi emprestado para {usuario.Nome}.");
    }

    public void DevolverLivro(Livro livro, Usuario usuario)
    {
        if (Livros.Contains(livro))
        {
            livro.Devolver();
            Console.WriteLine($"{livro.Titulo} foi devolvido por {usuario.Nome}.");
        }
    }

    public Livro? BuscarLivroPorTitulo(string titulo)
    {
        return Livros.FirstOrDefault(l => l.Titulo.Trim().Equals(titulo.Trim(), StringComparison.OrdinalIgnoreCase));
    }

    public Usuario? BuscarUsuarioPorId(int id)
    {
        return Usuarios.FirstOrDefault(u => u.Id == id);
    }

    public void AtualizarLivro(string titulo, string novoTitulo, string novoAutor, string novoIsbn, string novoGenero, int novaQuantidade)
    {
        var livro = BuscarLivroPorTitulo(titulo);
        if (livro != null)
        {
            livro.Titulo = novoTitulo;
            livro.Autor = novoAutor;
            livro.Isbn = novoIsbn;
            livro.Genero = novoGenero;
            livro.QuantidadeEmEstoque = novaQuantidade;
            Console.WriteLine("Livro atualizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    public void AtualizarUsuario(int id, string novoNome, string novoEndereco, string novoTelefone)
    {
        var usuario = BuscarUsuarioPorId(id);
        if (usuario != null)
        {
            usuario.Nome = novoNome;
            usuario.Endereco = novoEndereco;
            usuario.Telefone = novoTelefone;
            Console.WriteLine("Usuário atualizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Usuário não encontrado.");
        }
    }

    public void MostrarLivrosDisponiveis()
    {
        Console.WriteLine("Livros disponíveis para empréstimo:");
        Console.WriteLine("-----------------------------------");
        foreach (var livro in Livros.Where(l => l.QuantidadeEmEstoque > 0))
        {
            livro.ExibirInformacoes();
            Console.WriteLine("-----------------------------------");
        }
    }

    public List<Livro> PesquisarPorTitulo(string titulo)
    {
        return Livros.Where(l => l.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Livro> PesquisarPorAutor(string autor)
    {
        return Livros.Where(l => l.Autor.Contains(autor, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Livro> PesquisarPorGenero(string genero)
    {
        return Livros.Where(l => l.Genero.Contains(genero, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public void MostrarUsuarios()
    {
        Console.WriteLine("Usuários cadastrados:");
        Console.WriteLine("-----------------------------------");
        foreach (var usuario in Usuarios)
        {
            usuario.ExibirDetalhes();
            Console.WriteLine("-----------------------------------");
        }
    }
}