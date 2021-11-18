using System;

namespace PalindromeKelimeler
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle = "bu gün hava çok güzel....arkadaşlar ile kavak olan bir yere gittik. tabi gitmeden ütü yaptım. orada ata bindim....";
            string[] cumleler = cumle.Split(' '); // boşluğa göre dizi oluştur....
            foreach (var item in cumleler)
            {
                char[] kelime = item.ToCharArray();
                Array.Reverse(kelime);
                if (string.Compare(item, new string(kelime)).ToString() == "0")
                {
                    Console.WriteLine($"{item}");
                }

                     // tam burada bu cümle içrisindeki palindrome kelimeleri ekrana yazdırınız...
                    // ütü - palindromdur...
                
            }

            Console.ReadKey();
        }
    }
}
