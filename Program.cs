using System;

namespace aula_20_11
{
    class Program
    {
        static void Main(string[] args){
            
            Console.WriteLine("Digite o nome do aluno");
            string nome = Console.ReadLine();
            
            Console.WriteLine("digite a primeira nota");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite a segunda nota");
            int valor2 = int.Parse(Console.ReadLine());

            Media(valor1, valor2);

            void Media(int v1, int v2){
                float media = (v1+v2)/2;
                Console.WriteLine($"O aluno(a) "+nome+" obteve a média de :"  +media);
            }

            if(valor1+valor2/2< 0 || valor1+valor2/2> 7){
            Console.WriteLine("O aluno "+nome+" está APROVADO com a média de :" );}

            Console.WriteLine("Você deseja ver quem foi aprovado?");
            string aprovado = Console.ReadLine();
            
           
            
        }
  }
}
