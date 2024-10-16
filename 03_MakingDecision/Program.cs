using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şİfre Yanlış!");
            //}

            //string capital, country;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int number;

            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if(average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;

            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if (city == "ankara" | city == "adana" | city == "istanbul" | city == "giresun")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz.");
            //}



            #endregion

            #region Mod işlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else {
            //    Console.WriteLine("Sayı tektir");
            //}

            #endregion

            #region Char değişkenleri karar yapıları

            //char team;
            //Console.Write("Lütfen takımınızın sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Uygulama Projesi
            //Console.WriteLine("C# Eğitim Kampı Restoran");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Lütfen detayı görmek istediğiniz menüyü seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Etli Pilav");
            //    Console.WriteLine("4- Fırında Makarna");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Kremalı Tavuk Çorbası");
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz Pizza");
            //    Console.WriteLine("2- Margarita");
            //    Console.WriteLine("3   k- Tavuklu Pizza");
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Trileçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Profiterol");
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthnumber = int.Parse(Console.ReadLine());

            //switch (monthnumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi yaptınız"); break;
            //}

            #endregion

            #region Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapıcağınız işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol) {
            
            //    case '+': 
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-': 
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result); 
            //        break;

            //    case '*': 
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result); 
            //        break;

            //    case '/': 
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result); 
            //        break;

            //    default: Console.Write("Hatalı veri girişi."); break;
            //}

            

            #endregion

            Console.Read();
        }
    }
}
