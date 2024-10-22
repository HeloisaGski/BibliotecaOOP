public class Usuario
{
    public string Nome { get; set; }
    public int Id { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public List<Livro> HistoricoEmprestimos { get; private set; }

    public Usuario(string nome, int id, string endereco, string telefone)
    {
        Nome = nome;
        Id = id;
        Endereco = endereco;
        Telefone = telefone;
        HistoricoEmprestimos = new List<Livro>();
    }

    public void AdicionarEmprestimo(Livro livro)
    {
        HistoricoEmprestimos.Add(livro);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}, ID: {Id}, Endereço: {Endereco}, Telefone: {Telefone}");
        Console.WriteLine("Histórico de Empréstimos:");
        foreach (var livro in HistoricoEmprestimos)
        {
            Console.WriteLine($"- {livro.Titulo}");
        }
    }
}
