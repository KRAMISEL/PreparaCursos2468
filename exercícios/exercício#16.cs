using System;
class program{
    static void Main(){
       Console.Write("Quantos cigarros você fuma por dia? ");
       int cigarros = int.Parse(Console.ReadLine());
       Console.Write("E a quantos anos você fuma? ");
       int anos = int.Parse(Console.ReadLine());
       Console.WriteLine("Você já perdeu {0} dias da sua vida.",(cigarros * 10) * (365 * anos));
    }
}