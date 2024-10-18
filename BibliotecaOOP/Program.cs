            Biblioteca biblioteca = new Biblioteca();

            Livro livro1 = new Livro("Harry Potter e a Pedra Filosofal", "J.K. Rowling", "978-85-325-0043-2", "Fantasia", 10);
            Livro livro2 = new Livro("Harry Potter e a Câmara Secreta", "J.K. Rowling", "978-85-325-0077-0", "Fantasia", 8);
            Livro livro3 = new Livro("Harry Potter e o Prisioneiro de Azkaban", "J.K. Rowling", "978-85-325-0081-7", "Fantasia", 7);
            Livro livro4 = new Livro("Harry Potter e o Cálice de Fogo", "J.K. Rowling", "978-85-325-0088-6", "Fantasia", 1);
            Livro livro5 = new Livro("Harry Potter e a Ordem da Fênix", "J.K. Rowling", "978-85-325-0095-4", "Fantasia", 6);
            Livro livro6 = new Livro("Harry Potter e o Enigma do Príncipe", "J.K. Rowling", "978-85-325-0105-0", "Fantasia", 4);
            Livro livro7 = new Livro("Harry Potter e as Relíquias da Morte", "J.K. Rowling", "978-85-325-0106-7", "Fantasia", 3);


            biblioteca.AdicionarLivro(livro1);
            biblioteca.AdicionarLivro(livro2);
            biblioteca.AdicionarLivro(livro3);
            biblioteca.AdicionarLivro(livro4);
            biblioteca.AdicionarLivro(livro5);
            biblioteca.AdicionarLivro(livro6);
            biblioteca.AdicionarLivro(livro7);

            Usuario usuario1 = new Usuario("Heloisa", 1, "Rua D, 123", "9999-8888");
            Usuario usuario2 = new Usuario("Sabrina", 2, "Rua C, 456", "9999-7777");
            Usuario usuario3 = new Usuario("Kailan", 3, "Rua G, 123", "9999-6666");
            Usuario usuario4 = new Usuario("Andry", 4, "Rua L, 456", "9999-5555");
            Usuario usuario5 = new Usuario("Luiza", 5, "Rua D, 123", "9999-4444");
            Usuario usuario6 = new Usuario("Issa", 6, "Rua K, 456", "9999-3333");
            Usuario usuario7 = new Usuario("Maria Clara", 7, "Rua F, 123", "9999-2222");
            Usuario usuario8 = new Usuario("Julian", 8, "Rua V, 456", "9999-1111");          

            biblioteca.AdicionarUsuario(usuario1);
            biblioteca.AdicionarUsuario(usuario2);
            biblioteca.AdicionarUsuario(usuario3);
            biblioteca.AdicionarUsuario(usuario4);
            biblioteca.AdicionarUsuario(usuario5);
            biblioteca.AdicionarUsuario(usuario6);
            biblioteca.AdicionarUsuario(usuario7);
            biblioteca.AdicionarUsuario(usuario8);


            biblioteca.EmprestarLivro(livro4, usuario1);
            biblioteca.EmprestarLivro(livro4, usuario2);
            biblioteca.EmprestarLivro(livro4, usuario3);
            biblioteca.DevolverLivro(livro4, usuario1);
            biblioteca.EmprestarLivro(livro4, usuario2);



            //biblioteca.EmprestarLivro(livro4, usuario1);
            //biblioteca.EmprestarLivro(livro1, usuario2);
            //biblioteca.EmprestarLivro(livro3, usuario3);
            //biblioteca.EmprestarLivro(livro2, usuario4);
            //biblioteca.EmprestarLivro(livro6, usuario5);
            //biblioteca.EmprestarLivro(livro6, usuario6);
            //biblioteca.EmprestarLivro(livro7, usuario7);
            //biblioteca.EmprestarLivro(livro5, usuario8);
           //biblioteca.DevolverLivro(livro4, usuario1);
           //biblioteca.DevolverLivro(livro1, usuario2);
           //biblioteca.DevolverLivro(livro3, usuario3);
           //biblioteca.DevolverLivro(livro2, usuario4);
           //biblioteca.DevolverLivro(livro6, usuario5);
           //biblioteca.DevolverLivro(livro6, usuario6); 
           //biblioteca.DevolverLivro(livro7, usuario7); 
           //biblioteca.DevolverLivro(livro5, usuario8); 
           


            



       

