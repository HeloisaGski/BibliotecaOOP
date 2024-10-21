public class Livro : ItemBiblioteca, IEmprestavel, IPesquisavel
{
    public string isbn;
    public string genero;
    private int quantidadeEstoque;
    private bool emprestado;

    public int QuantidadeEmEstoque
    {
        get { return quantidadeEstoque; }
        set { quantidadeEstoque = value; }
    }

    public Livro(string titulo, string autor, string isbn, string genero, int quantidadeEstoque) 
        : base(titulo, autor)
    {
        this.isbn = isbn;
        this.genero = genero;
        this.quantidadeEstoque = quantidadeEstoque;
        this.emprestado = false;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes(); 
        Console.WriteLine("ISBN: " + isbn);
        Console.WriteLine("Gênero: " + genero);
        Console.WriteLine("Quantidade em estoque: " + quantidadeEstoque);
        Console.WriteLine("Status do empréstimo: " + (emprestado ? "Emprestado" : "Disponível"));
    }

    public void Emprestar(Usuario usuario)
    {
        if (quantidadeEstoque > 0 && !emprestado)
        {
            emprestado = true;
            quantidadeEstoque--;
            Console.WriteLine($"Livro '{Titulo}' emprestado para {usuario.Nome}.");
        }
        else
        {
            Console.WriteLine("O livro não está disponível para empréstimo.");
        }
    }

    public void Devolver()
    {
        if (emprestado)
        {
            emprestado = false;
            quantidadeEstoque++;
            Console.WriteLine($"Livro '{Titulo}' devolvido.");
        }
        else
        {
            Console.WriteLine("O livro não está emprestado.");
        }
    }

    public List<Livro> PesquisarPorTitulo(string titulo)
    {
        return new List<Livro>(); 
    }

    public List<Livro> PesquisarPorAutor(string autor)
    {
        return new List<Livro>(); 
    }

    public List<Livro> PesquisarPorGenero(string genero)
    {
        return new List<Livro>(); 
    }
}
