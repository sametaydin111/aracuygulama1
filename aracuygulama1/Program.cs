using System;
using System.IO;

namespace aracuygulama1
{

    class arac
    {
        public string marka;
        public int yıl;
        public string model;
        public string tür;
        public void ozellikgoster()
        {
            Console.WriteLine("-arabanin ozellikleri-\nMarka={0}\nYılı={1}\nModeli={2}\nTür={3}", marka, yıl, model, tür);
        }
    }
    class taşıt : arac
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            taşıt ab = new taşıt();
            StreamWriter SW = File.AppendText(@"C:\Users\xlaxter\Desktop\Yeni Metin Belgesi.txt");
            Console.WriteLine("sırasıyla marka, yıl, model ve türünü giriniz.");
            ab.marka = Console.ReadLine();
            SW.WriteLine(ab.marka);
            ab.yıl = Convert.ToInt32(Console.ReadLine());
            SW.WriteLine(ab.yıl);
            ab.model = Console.ReadLine();
            SW.WriteLine(ab.model);
            ab.tür = Console.ReadLine();
            SW.WriteLine(ab.tür);
            ab.ozellikgoster();
            Console.ReadKey();

            string kaydet = Console.ReadLine();
            SW.WriteLine(kaydet);
            SW.Close();
        }

    }
}