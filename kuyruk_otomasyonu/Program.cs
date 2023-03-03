using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace kuyruk_otomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kişi sayısının 4 olduğu bir kuyruk olacak döngü her döndüğünde
            // bana sonuncu elemana sıra gelmesi için kaç kişinin kaldığını
            // random bir süre aralığıyla gösterecek.

            Queue kuyruk = new Queue();

            kuyruk.Enqueue("Tolga");
            kuyruk.Enqueue("Mehmet");
            kuyruk.Enqueue("Özge");
            kuyruk.Enqueue("Özlem");

            try
            {
                Console.WriteLine("Kuyrukta {0} kişi vardır.", kuyruk.Count);
                Ayirac();

                for (int i = 4; i >= 1; i--)
                {
                    Console.WriteLine("{0} kişi kaldı", i);
                    Thread.Sleep(2000);

                    //string isim = (string)kuyruk.Dequeue();
                    //Console.WriteLine(isim);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ups!! Bir hata oluştu.");
            }
            Console.WriteLine("Şimdi sıraa sizde..");
            Console.ReadLine();

        }
        static void Ayirac()
        {
            Console.WriteLine("****************");
        }
    }
}
    