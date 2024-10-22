public class Livro : ItemBiblioteca, IEmprestavel
{
    public string Isbn { get; set; }
    public string Genero { get; set; }
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
        this.Isbn = isbn;
        this.Genero = genero;
        this.quantidadeEstoque = quantidadeEstoque;
        this.emprestado = false;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine("ISBN: " + Isbn);
        Console.WriteLine("Gênero: " + Genero);
        Console.WriteLine("Quantidade em estoque: " + quantidadeEstoque);
        Console.WriteLine("Status do empréstimo: " + (emprestado ? "Emprestado" : "Disponível"));
    }

    public void Emprestar(Usuario usuario)
    {
        if (quantidadeEstoque > 0 && !emprestado)
        {
            emprestado = true;
            quantidadeEstoque--;
            usuario.AdicionarEmprestimo(this);
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
        }
        else
        {
            Console.WriteLine("O livro não está emprestado.");
        }
    }
}