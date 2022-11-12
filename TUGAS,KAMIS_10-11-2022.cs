using System;
class AritmatikaPenjumlahan
{
 public static void Main (string[] args)
 {
     int mangga, apel, hasil = 0;
     Console.Write("Mangga = ");
     mangga = int.Parse(Console.ReadLine());
     Console.Write("apel = ");
     apel = int.Parse(Console.ReadLine());
     
     // operasi penjumlahan dengan operator +
     hasil = mangga + apel;
     Console.WriteLine ($"Hasil mangga + apel = {hasil}");
 }
}