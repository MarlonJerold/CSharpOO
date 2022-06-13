using System;

namespace ProjetoDotnet
{
    public class Program
    {
         static void Demo1(){
            Pessoa p1 = new Pessoa();

            p1.Nome = "Jerold";
            p1.Documento = "55445";
            p1.Idade = 21;

           }
           static void Demo2(){
            
            StructPessoa p2 = default; 

            p2.Nome = "Marlon";
            p2.Documento = "545";
            p2.Idade = 21;
            Console.WriteLine(p2.Nome);

            var p1 = p2;

            p1 = TrocaNome(p1, "Jerold");

           Console.WriteLine($"o valor de p1 é {p1.Nome}");
           Console.WriteLine($"o valor de p2 é {p2.Nome}");

           }
        
        
        static void TrocarNome(Pessoa p1, string NovoNome){
            p1.Nome = NovoNome;
        }

        static StructPessoa TrocaNome(StructPessoa p1, string NovoNome){
            p1.Nome = NovoNome; 
            return p1;
        }

        static void Main(string[] args)
        {
            return;
        }
    }
}