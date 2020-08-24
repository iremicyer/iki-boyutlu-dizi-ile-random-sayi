using System;
using System.Drawing;
using System.Net.Http.Headers;

namespace RandomİkiBoyutlu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("satir sayisini giriniz:"); // kullancııdan satir sayisinin alinmasi
            int satir = Convert.ToInt32(Console.ReadLine());

            Console.Write("sütun sayisi giriniz:"); // kuullanıcıdan sütun sayisinin alinmasi
            int sütun = Convert.ToInt32(Console.ReadLine());

          

            Random rnd = new Random(); // random sayi üretmek için fonksiyon oluşturulması

            int[,] dizi = new int[sütun, satir]; // iki boyutlu dizi tanimlanmasi

            for (int i = 0;  i< sütun; i++)  
            {
                for (int j = 0; j < satir; j++)
                {
                    dizi[i,j] = rnd.Next(0,100);
                    Console.Write(dizi[i,j] +"\t" );

                     //Console.Write(random[i, j] + " \t"); //  \t dizide sağa doğru bir tab boşulk bırakılmasını sağlar.

                   
                }
                Console.WriteLine("\n"); // girilen boyutlara göre dizisinin aşağı doğru devam ettirilmesi.

           
            }
            Console.ReadKey();


        }
    }
}
