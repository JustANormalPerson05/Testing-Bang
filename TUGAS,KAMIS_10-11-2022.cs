using System;
class AritmatikaPenjumlahan
{
 public static void Main (string[] args)
 {
     int mangga, apel, jambu, Srikaya, hasil = 0;
     Console.Write("Mangga = ");
     mangga = int.Parse(Console.ReadLine());
     Console.Write("apel = ");
     apel = int.Parse(Console.ReadLine());
     Console.Write("jambu = ");
     jambu = int.Parse(Console.ReadLine());
     Console.Write("Srikaya = ");
     Srikaya = int.Parse(Console.ReadLine());
     // operasi penjumlahan dengan operator +
     hasil = mangga + apel + jambu + Srikaya;
     Console.WriteLine ($"Hasil mangga + apel + jambu + Srikaya = {hasil}");
 }
}