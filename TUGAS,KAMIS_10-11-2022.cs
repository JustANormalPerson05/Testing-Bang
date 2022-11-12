using System;
class AritmatikaPenjumlahan
{
 public static void Main (string[] args)
 {
     int mangga, apel, jambu, hasil = 0;
     Console.Write("Mangga = ");
     mangga = int.Parse(Console.ReadLine());
     Console.Write("apel = ");
     apel = int.Parse(Console.ReadLine());
     Console.Write("jambu = ");
     jambu = int.Parse(Console.ReadLine());
     
     // operasi penjumlahan dengan operator +
     hasil = mangga + apel + jambu;
     Console.WriteLine ($"Hasil mangga + apel + jambu = {hasil}");
 }
}