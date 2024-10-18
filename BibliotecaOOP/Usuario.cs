    public class Usuario
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Usuario(string nome, int id, string endereco, string telefone)
        {
            Nome = nome;
            Id = id;
            Endereco = endereco;
            Telefone = telefone;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {Nome}, ID: {Id}, Endereço: {Endereco}, Telefone: {Telefone}");
        }
    }

