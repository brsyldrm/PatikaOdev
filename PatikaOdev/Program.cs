using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ödev1
            #region 1.Algoritma
            //1.Algoritma
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            //Console.WriteLine("Pozitif bir sayı giriniz.");
            //int input = int.Parse(Console.ReadLine());
            //if (input <= 0)
            //{
            //    Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
            //    input = int.Parse(Console.ReadLine());

            //}
            //int[] sayilar= new int[input];
            //for(int i =0; i < input; i++)
            //{
            //    Console.WriteLine("Sayı giriniz.");
            //    int input2= int.Parse(Console.ReadLine());
            //    sayilar[i] = input2;
            //}
            //foreach (var item in sayilar)
            //{
            //    if (item%2==0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion
            #region 2.Algoritma
            //2.Algoritma
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            //Console.WriteLine("Lütfen Pozitif iki sayı giriniz.");
            //int input = int.Parse(Console.ReadLine());
            //int input2 = int.Parse(Console.ReadLine());
            //if (input <= 0&&input2<=0)
            //{
            //    Console.WriteLine("Lütfen Pozitif iki sayı giriniz.");
            //    input = int.Parse(Console.ReadLine());
            //    input2 = int.Parse(Console.ReadLine());
            //}
            //int[] sayilar = new int[input];
            //for (int i = 0; i < input; i++)
            //{
            //    Console.WriteLine("Sayı giriniz.");
            //    int input3= int.Parse(Console.ReadLine());
            //    sayilar[i] = input3;
            //}
            //foreach (var item in sayilar)
            //{
            //    if (item ==input2||item%input2==0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion
            #region 3.Algoritma
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            //Console.WriteLine("Pozitif bir sayı giriniz.");
            //int input = int.Parse(Console.ReadLine());
            //if (input <= 0)
            //{
            //    Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
            //    input = int.Parse(Console.ReadLine());
            //}
            //string[] kelimeler = new string[input];
            //for (int i = 0; i < input; i++)
            //{
            //    Console.WriteLine("Kelime giriniz.");
            //    string input2 = Console.ReadLine();
            //    kelimeler[i] = input2;
            //}
            //Array.Reverse(kelimeler);
            //foreach (var item in kelimeler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4.Algoritma
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("Cümle yazınız.");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            int w=words.Count();
            char[] c=input.Replace(" ",string.Empty).ToCharArray();
            int c1=c.Count();
            Console.WriteLine("Kelime sayısı: {0},Harf sayısı: {1}", w, c1);
            #endregion
            Console.ReadKey();
            

        }
    }
}
