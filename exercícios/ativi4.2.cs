using System;
class programa{
    static void Main(){
        int A = 10,B = A / 2;
        float[] núm = new float[A];
        Console.WriteLine("Preencha o vetor com números.");
        for(int i = 0; i < núm.Length / 2; i++){
            núm[i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < núm.Length / 2; i++){
            núm[i + núm.Length / 2] = núm[i];
        }
        for(int i = 0; i < núm.Length / 2; i++){
            núm[B -= 1] = núm[i + núm.Length / 2];
        }
        Console.Write("\n=========");
        for(int i = 0; i < núm.Length / 2; i++){
            Console.WriteLine("\n{0}",núm[i]);
        }
        Console.WriteLine("=========");
    }
}