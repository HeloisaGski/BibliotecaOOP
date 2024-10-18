public interface IUsuario
{
    void AdicionarUsuario(Usuario usuario);
    void ExibirUsuarios();
}

public interface IEmprestavel
{
    void Emprestar(Usuario usuario);
    void Devolver();
}

public interface IPesquisavel
{
    List<Livro> PesquisarPorTitulo(string titulo);
    List<Livro> PesquisarPorAutor(string autor);
    List<Livro> PesquisarPorGenero(string genero);
}

public class UsuarioRepositorio : IUsuario
{
    private List<Usuario> usuarios = new List<Usuario>();

    public void AdicionarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
        Console.WriteLine("Usuário adicionado: " + usuario.Nome);
    }

    public void ExibirUsuarios()
    {
        foreach (var usuario in usuarios)
        {
            usuario.ExibirDetalhes();
        }
    }
}
