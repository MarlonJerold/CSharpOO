
namespace ProjetoDotnet
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public string Documento {get; set;}
        public int Idade {get; set;}
        
        public string TrocarNome(string Anterior, string NovoNome){
           return Anterior = NovoNome;
        }

        public Pessoa Clone(){
            return new Pessoa(){
                Nome = this.Nome,
                Documento = this.Documento
            };
        }
    }
}