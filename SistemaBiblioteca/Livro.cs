
    public class Livro{
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public bool Disponibilidade { get; private set; }

        public Livro(string titulo, string autor ){
            Titulo = titulo;
            Autor = autor;
            Disponibilidade = true;
        }

        public string Emprestar(){
            if (!Disponibilidade){
                return "Erro: O livro ja está emprestado.";
            }
            else
            {
                Disponibilidade = false;
                return $"O Livro {Titulo} foi emprestado com sucesso!";
            }
        }
        public string Devolver(){
            Disponibilidade = true;
            return $"O Livro {Titulo} foi devolvido com sucesso!";
        }
    }