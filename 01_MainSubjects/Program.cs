﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* YAZDIRMA KOMUTLARI
            //Console.WriteLine("Merhaba Dünya");
			//Console.Write("Selam");

			//Console.WriteLine("***** Yemek Kategorileri *****");
			//Console.WriteLine();
			//Console.WriteLine("1-Çorbalar");
			//Console.WriteLine("2-Ana Yemekler");
			//Console.WriteLine("3-Soğuk Başlangıçlar");
			//Console.WriteLine("4-Salatalar");
			//Console.WriteLine("5-Tatlılar");
			//Console.WriteLine("6-İçecekler");
			//Console.WriteLine();
			//Console.WriteLine("***** Yemek Kategorileri *****");
             */

            /*  STRING DEGISKENLER
              string customerName;
              string customerSurname;
              string customerPhone;
              string customerEmail,district,city;

              customerName = "Ali";
              customerSurname = "Çınar";
              customerPhone = "+90 500 400 30 40";
              customerEmail = "deneme@gmail.com";
              district = "Kadıköy";
              city = "İstanbul";

              Console.WriteLine("*** Rezervasyon Kartı ***");
              Console.WriteLine();
              Console.WriteLine("-----------------------------------------------------");
              Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
              Console.WriteLine("İletişim: " + customerPhone);
              Console.WriteLine("Email adresi: " + customerEmail);
              Console.WriteLine("Adres: " + district + "/" + city);
              Console.WriteLine("-----------------------------------------------------");
              Console.WriteLine();

              customerName = "Ayşegül";
              customerSurname = "Kaya";
              customerPhone = "+90 500 400 30 40";
              customerEmail = "test@gmail.com";
              district = "Fethiye";
              city = "Muğla";

              Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
              Console.WriteLine("İletişim: " + customerPhone);
              Console.WriteLine("Email adresi: " + customerEmail);
              Console.WriteLine("Adres: " + district + "/" + city);
              Console.WriteLine("-----------------------------------------------------");

              Console.Read();

              */

			// INT DEGISKENLER
            int hamburgerPrice = 300;
			int cokePrice = 35;
			int waterPrice = 10;
			int friesPrice = 50;
			int pizzaPrice = 250;
			int lemonadePrice = 30;

			Console.WriteLine("**** Restoran Menü Fiyatı ****");
			Console.WriteLine();
			Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
			Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
			Console.WriteLine("-----Kola: " + cokePrice + " TL");
			Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
			Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
			Console.WriteLine("-----Su: " + waterPrice + " TL");
			Console.WriteLine();
			Console.WriteLine("**** Restoran Menü Fiyatı ****");


			Console.WriteLine();
			int hamburgerCount;
			int cokeCount;
			int waterCount;
			int friesCount;
			int pizzaCount;
			int lemonadeCount;

			int totalHamgurgerPrice;
			int totalCokePrice;
			int totalWaterPrice;
			int totalFriesPrice;
			int totalPizzaPrice;
			int totalLemonadePrice;

			hamburgerCount = 3;
			cokeCount = 3;
			waterCount = 3;
			friesCount = 1;
			pizzaCount = 0;
			lemonadeCount = 0;

			totalHamgurgerPrice = hamburgerCount * hamburgerPrice;
			totalCokePrice = cokeCount * cokePrice;
			totalWaterPrice = waterCount * waterPrice;
			totalLemonadePrice = lemonadeCount * lemonadePrice;
			totalFriesPrice = friesCount * friesPrice;
			totalPizzaPrice = pizzaCount * pizzaPrice;

			Console.WriteLine("-------------------------------------");
			Console.WriteLine("Hamburger Tutarı: " + totalHamgurgerPrice + " TL");
			Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
			Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
			Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
			Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
			Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

			Console.WriteLine();

			int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamgurgerPrice + totalPizzaPrice + totalFriesPrice;

			Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

            Console.Read();




        }
    }
}