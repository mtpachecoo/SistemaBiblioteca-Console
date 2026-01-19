Livro[] livros = new Livro[1];

livros[0] = new Livro("1984", "George Orwell");
    Livro livro = new Livro(livros[0]);


Console.WriteLine(livros[0].Emprestar());
Console.WriteLine(livros[0].Devolver());

