public class ItemBiblioteca
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public ItemBiblioteca(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
    }

}

    