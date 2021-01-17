using System;
using System.Net;



namespace ConsoleApp2
{
    class Program
    {
        [Obsolete]
        private static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed; Console.Clear(); Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Pc ip adressş \n          ve\ncihaz adınız =\n________________________________________________________________");
            Console.WriteLine("");
            string hostAdi = Dns.GetHostName();
            //Makine adını buluyoruz

            Console.WriteLine("Host Adı = " + hostAdi);

            IPHostEntry yerel = Dns.GetHostByName(hostAdi);
            //yerel değişkeni yaratıp makinede arama sağlayacağız

            foreach (IPAddress ipadres in yerel.AddressList)
            //döngüye tüm ipleri bulmak için sokuyoruz

            {

                Console.WriteLine("IP Adresi = " + ipadres.ToString());
                //ipleri yazdırıyoruz

            }

            Console.ReadLine();
            //console ekranını bekletmek için kullanıyoruz

        }
    }
}
