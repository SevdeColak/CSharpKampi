using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler
            ////double number;
            ////number = 5.20;
            ////Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice);
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice);
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice);
            //Console.WriteLine("---- Patates Birim Fİyatı: " + potatoPrice);
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice);

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double totalPrice;

            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: ELma, Birim Fiyatı: " + applePrice
            //    + ", Gramaj: " + appleGram + ", Toplam Tutar: " + appleGram * applePrice);
            //Console.WriteLine("Alınan Ürün: Portakal, Birim Fiyatı: " + orangePrice
            //    + ", Gramaj: " + orangeGram + ", Toplam Tutar: " + orangeGram * orangePrice);
            //Console.WriteLine("Alınan Ürün: Çilek, Birim Fiyatı: " + strawberryPrice
            //    + ", Gramaj: " + strawGram + ", Toplam Tutar: " + strawGram * strawberryPrice);
            //Console.WriteLine("Alınan Ürün: Patates, Birim Fiyatı: " + potatoPrice
            //    + ", Gramaj: " + potatoGram + ", Toplam Tutar: " + potatoGram * potatoPrice);
            //Console.WriteLine("Alınan Ürün: Domates, Birim Fiyatı: " + tomatoPrice
            //    + ", Gramaj: " + tomatoGram + ", Toplam Tutar: " + tomatoGram * tomatoPrice);

            //Console.WriteLine();

            //totalPrice = (appleGram * applePrice) + (orangeGram * orangePrice)
            //    + (strawGram * strawberryPrice) + (potatoGram * potatoPrice) + (tomatoGram * tomatoPrice);

            //Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden String Değişkenler Veri Gİrişi

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengername, passengersurname, passengerdistrict, passengercity, passengerage,
            //    passengeridentitynumber;

            //Console.Write("Yolcu Adı: ");
            //passengername = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengersurname = Console.ReadLine();

            //Console.Write("İLçe Bilgisi: ");
            //passengerdistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengercity = Console.ReadLine();

            //Console.Write("Yaş Bilgisi: ");
            //passengerage = Console.ReadLine();

            //Console.Write("TC Kimlik Numarası: ");
            //passengeridentitynumber = Console.ReadLine();



            //Console.WriteLine();

            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Yolcu Adı Soyadı: " +  passengername + " " + passengersurname + 
            //    " -- TC Kimlik Numarası: " + passengeridentitynumber + " -- Yolcu Yaşı: " + passengerage + 
            //    " -- Adres Bilgisi: " + passengerdistrict + "/" + passengercity);

            #endregion

            #region Klavyeden Int Değişkenler Veri Girişi ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 2000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice 
            //    + chairCount * chairPrice + tvPrice * tvCount;

            //Console.WriteLine("Toplam Ödemeniz gereken tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri ve Dönüşümleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunuzu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunuzu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunuzu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion
            Console.Read();


        }
    }
}
