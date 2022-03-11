using System;

namespace tpmodul3_1302204047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kelurahan1 = new KodePos(namaKelurahan.Batununggal);
            Console.WriteLine($"Kelurahan\t\t: {kelurahan1.Kelurahan}");
            Console.WriteLine($"Kode Pos\t\t: {kelurahan1.getKodePos()}");
            
            var kelurahan2 = new KodePos(namaKelurahan.Kujangsari);
            Console.WriteLine($"Kelurahan\t\t: {kelurahan2.Kelurahan}");
            Console.WriteLine($"Kode Pos\t\t: {kelurahan2.getKodePos()}");
            
            var kelurahan3 = new KodePos(namaKelurahan.Mengger);
            Console.WriteLine($"Kelurahan\t\t: {kelurahan3.Kelurahan}");
            Console.WriteLine($"Kode Pos\t\t: {kelurahan3.getKodePos()}");
           
            var kelurahan4 = new KodePos(namaKelurahan.Wates);
            Console.WriteLine($"Kelurahan\t\t: {kelurahan4.Kelurahan}");
            Console.WriteLine($"Kode Pos\t\t: {kelurahan4.getKodePos()}");
            
            var kelurahan5 = new KodePos(namaKelurahan.Cijaura);
            Console.WriteLine($"Kelurahan\t\t: {kelurahan5.Kelurahan}");
            Console.WriteLine($"Kode Pos\t\t: {kelurahan5.getKodePos()}");
            
            var kelurahan6 = new KodePos(namaKelurahan.Jatisari);
            Console.WriteLine($"Kelurahan\t\t: {kelurahan6.Kelurahan}");
            Console.WriteLine($"Kode Pos\t\t: {kelurahan6.getKodePos()}");
            
            var kelurahan7 = new KodePos(namaKelurahan.Margasari);
            Console.WriteLine($"Kelurahan\t\t: {kelurahan7.Kelurahan}");
            Console.WriteLine($"Kode Pos\t\t: {kelurahan7.getKodePos()}");
            
            var kelurahan8 = new KodePos(namaKelurahan.Sekejati);
            Console.WriteLine($"Kelurahan\t\t: {kelurahan8.Kelurahan}");
            Console.WriteLine($"Kode Pos\t\t: {kelurahan8.getKodePos()}");
            
            var kelurahan9 = new KodePos(namaKelurahan.Kebonwaru);
            Console.WriteLine($"Kelurahan\t\t: {kelurahan9.Kelurahan}");
            Console.WriteLine($"Kode Pos\t\t: {kelurahan9.getKodePos()}");
            
            var kelurahan10 = new KodePos(namaKelurahan.Maleer);
            Console.WriteLine($"Kelurahan\t\t: {kelurahan10.Kelurahan}");
            Console.WriteLine($"Kode Pos\t\t: {kelurahan1.getKodePos()}");
            
            var kelurahan11= new KodePos(namaKelurahan.Samoja);
            Console.WriteLine($"Kelurahan\t\t: {kelurahan11.Kelurahan}");
            Console.WriteLine($"Kode Pos\t\t: {kelurahan11.getKodePos()}");

            var doorMachine = new DoorMachine();
            doorMachine.printStatus();
            doorMachine.setKeadaan(Keadaan.Terbuka);
            doorMachine.printStatus();
        }
    }
}