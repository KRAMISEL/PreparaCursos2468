using System;
class Programa{
    static void Main(){
        int a = 4;
        int[,] números = new int[a,a];
        Console.WriteLine("Digite números:");
        for(int A = 0; A < a; A++){
            for(int B = 0; B < a; B++){
                números[A,B] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("====================>");
        for(int A = 0; A < a; A++){
            for(int B = 0; B < a; B++){
                Console.WriteLine(números[A,B]);
            }
        }
        Console.WriteLine("====================>");
    }
}