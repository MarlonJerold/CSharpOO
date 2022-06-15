using System;
using System.Collections.Generic;
using System.Data;

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
        static void Demo3(){
        
            string nome = "Marlon";
            TrocaNome(nome, "Jerold");
            System.Console.WriteLine($"O novo nome é {nome}");

           }
        static void Demo4(){
            var pares = new int[]{0,2,4,6,8};

            MudarParaImpar(pares);

            System.Console.WriteLine($"Os impares = {string.Join(",", pares)}");
        } 
        static void Demo5() {
            int[] numeros = new int[]{0,2,4,6,8};
            System.Console.Write($"Digite um número que gostria de encontrar: ");
            var numero = int.Parse(Console.ReadLine());
            var idxEncontrado = EncontrarNumeros(numeros, numero);

            System.Console.WriteLine($"o numero digitado é {idxEncontrado}");
        }              
        static void TrocarNome(Pessoa p1, string NovoNome){

            p1.Nome = NovoNome;
        }

        static StructPessoa TrocaNome(StructPessoa p1, string NovoNome){

            p1.Nome = NovoNome; 
            return p1;
        }

        static void TrocaNome(string nome, string nomeNovo){

            nome = nomeNovo;
        }

        static void MudarParaImpar(int[] pares){

            for (int i = 0; i < pares.Length ; i++)
            {
                pares[i] = pares[i] + 1;
            }

        }
        static int EncontrarNumeros(int[] numeros, int numero){
            for (int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] == numero)       
                    return i;
                
            }
            return -1;   
        }
        static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa ){
            foreach (var item in pessoas)
            {
                if (item.Nome == pessoa.Nome)
                {
                    return true;
                }               
            }
            return false;
        }
        
        public static void Main(string[] args)
        {
                List<Pessoa> pessoas = new List<Pessoa>(){
                new Pessoa(){Nome = "Marlons"},
                new Pessoa(){Nome = "Jerold"},
                new Pessoa(){Nome = "Moura"},
                new Pessoa(){Nome = "Martins"},
            };

            System.Console.WriteLine($"Digite a pessoa que gostaria de localizar: ");

            var nome = Console.ReadLine();

            var pessoa = new Pessoa(){Nome = nome};
            var encontrado = EncontrarPessoa(pessoas, pessoa);
            if (encontrado)
            {
                System.Console.WriteLine("PESSOA LOCALIZADA!");
            }else
            {
                System.Console.WriteLine("PESSOA NAO LOCALIZADA!");
            }
        }
    }
}