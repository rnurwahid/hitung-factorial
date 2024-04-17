// 10. Menghitung Faktorial

using System;

public class HitungFaktorial
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("=============MENGHITUNG FAKRORIAL==========");
        Console.Write ("Masukkan angka: ");
        int angka = Convert.ToInt32(Console.ReadLine());
        int hasil =1;
        
        for (int i = 1; i <= angka; i++){
            hasil = hasil * i;
        }
        
        Console.WriteLine($"{angka}! = {hasil}");
    }
}