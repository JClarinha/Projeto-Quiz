// Neste projeto vamos fazer um simples Quiz cornometrado, com pontuação e no caso de uma resposta errada vai ser retirado o valor de 10% dessa mesma questão!
using System.Diagnostics;


Console.WriteLine("Olá seja muito bem vindo ao... \nDescobre um bocado de mim!\no tempo começa agora!");

System.Console.WriteLine(1);
Thread.Sleep(1000);
System.Console.WriteLine(2);
Thread.Sleep(1000);
System.Console.WriteLine(3);
//Criação de um cornómetro

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

int pontos = 0;
System.Console.WriteLine("Pergunta 1 = 10 pontos!");
System.Console.WriteLine("Para que serve a programação?\n A- Para o pessoal poder trabalhar em casa de cuecas!\n B- Para comunicarmos com máquinas!\n C- None of the above!");
string Resposta1 = System.Console.ReadLine(); 
int p1 = 10; // pontuação da pergunta
int percentagem1 = p1*10/100;



switch(Resposta1)
{
    case "b":
    case "B":
        System.Console.WriteLine("Fantástico acabas de ganhar 10 pontos!");
        pontos = pontos + p1;
        System.Console.WriteLine("Pontos = " + pontos);
        break;

    case "a":
    case "A":
        System.Console.WriteLine("De facto muito conveniente mas acabas de perder 10% do valor total da pargunta :(");
        pontos = pontos - percentagem1;
        System.Console.WriteLine("Pontos = " + pontos);
        break;

    case "c":
    case "C":
        System.Console.WriteLine("Not an option my friend! Menos 10% do valor da pergunta e estou a ser amigo!");
        pontos = pontos - percentagem1;
        System.Console.WriteLine("Pontos = " + pontos);
        break;

    default:
        System.Console.WriteLine("Mas estás a brincar com isto? Toma lá menos 20 pontos");
        pontos = pontos - 20;
        System.Console.WriteLine("Pontos = " + pontos);
        break;

}
    


System.Console.WriteLine("Pergunta 2 = 20 pontos!\nHTML é uma linguagem de progrmação?\n A- Sim!\n B- Não!");
int p2 = 20; //pontos da pergunta
string Resposta2 = System.Console.ReadLine();


switch(Resposta2)
{
    case "b":
    case "B":
        System.Console.WriteLine("Parabéns mais 20 pontos!");
        pontos = pontos + p2;
        System.Console.WriteLine("Pontos = " + pontos);
       
       break;

     case "a":
     case "A":
        System.Console.WriteLine("Esta era fácil porfavor!");
        int percentagem2 = p2 * 10 / 100;
        pontos = pontos - percentagem2;
        System.Console.WriteLine("Toma lá menos 10% do valor da resposta certa!");
        System.Console.WriteLine("Pontos = " + pontos);
        break;

    default:
        System.Console.WriteLine("No minimo tenta!");

        pontos = pontos - (p2 * 2);
        System.Console.WriteLine("Toma lá menos 40 pontos e é para os receberes com um sorriso!");
        System.Console.WriteLine("Pontos = " + pontos);
        break;
}



stopwatch.Stop();
TimeSpan tp = stopwatch.Elapsed;
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", tp.Hours, tp.Minutes, tp.Seconds);
System.Console.WriteLine("Tempo: " + elapsedTime);


Console.ReadLine();
