using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Linq;
using System.Data.SqlTypes;
using System.Security.AccessControl;

namespace fordonguleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("While ile döngü");
              int i = 0;
              while (i <= 10) 
              {
                  Console.WriteLine(i);
                  i++;
              }
              Console.WriteLine("Devam etmek için 'ENTER'");
              Console.ReadLine();
           


            Console.WriteLine("For ile döngü");

            for (int a = 0; a <= 10; a++)
            {
                Console.WriteLine(a);
            } 
              Console.WriteLine("Devam etmek için 'ENTER'");
              Console.ReadLine();

              Console.WriteLine("Bir Sayının Asal Mı Değil Mi Bulma");
              Console.WriteLine("Bir Sayı Giriniz");


              int Sayi1 = Convert.ToInt32(Console.ReadLine());
              bool bolunuyormu = false;
              for (int i = 2; i < Sayi1; i++)
              {
                  if (Sayi1%i==0)
                  {
                      bolunuyormu=true;
                      break;
                  }
              }
              if (bolunuyormu)
              {
                  Console.WriteLine("asal sayı değil");
              }
              else
              {
                  Console.WriteLine("asal sayıdır");
              }
            Console.WriteLine("Devam etmek için 'ENTER'");
              Console.ReadLine();

                Console.WriteLine("Klavyeden Girilen 'N' Tane Sayının Ortalaması");
            Console.WriteLine("Tekrar sayısını giriniz");

            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            int a;
            for (int i=1; i <= n; i++)
            {
                Console.WriteLine(i+"/"+n+"."+"Sayıyı Giriniz \n");

                a = Convert.ToInt32(Console.ReadLine());

                toplam = toplam+a;
            }
            Console.WriteLine("\n \n Ortalamaları  {0} " ,toplam/n);

            Console.WriteLine("Devam etmek için 'ENTER'");

            Console.ReadLine();  

              Console.WriteLine("çarpma op kullanmadan çarpma işlemi");

               Console.WriteLine("1. sayıyı giriniz");
               int a = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("2. sayıyı giriniz");
               int b = Convert.ToInt32(Console.ReadLine());

               int top = 0;

               if (a > 0)
               {
                   for (int i = 0; i < a; i++)
                   {
                       top = top + b;
                   }
                   Console.WriteLine(top);
               }
               else if (b > 0)
               {
                   for (int i = 0; i < b; i++)
                   {
                       top = top + a;
                   }
                   Console.WriteLine(top);
               }
               else if (b < 0 && a < 0)
               { 
               Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz");
               }

               Console.WriteLine("Devam etmek için 'ENTER'");
               Console.ReadLine(); 

              Console.WriteLine("Girilen sayı kadar sıralı sayı yazdırma");

            int deger=int.Parse(Console.ReadLine());

            for (int i = 0; i <= deger ; i++)
            {
                for (int j = 1; j <= i; j++)//i kaç değer alıyorsa içindeki değer o kadar döner
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Devam etmek için 'ENTER'");
            Console.ReadLine(); 

              Console.WriteLine("Girilen sayı kadar Tersten sıralı sayı yazdırma");

            int deger2 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= deger2; i++)
            {
                for (int j = 1; j <= deger2 - i; j++)//i kaç değer alıyorsa içindeki değer o kadar döner
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Devam etmek için 'ENTER'");
            Console.ReadLine(); 

             Console.WriteLine("Girilen sayıdan başlayarak geriye sıralı sayı yazdırma");

            int deger = int.Parse(Console.ReadLine());

            for (int i = 0; i <= deger; i++)
            {
                for (int j = 1; j <= i; j++)//i kaç değer alıyorsa içindeki değer o kadar döner
                {
                    Console.Write(deger + 1 - j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Devam etmek için 'ENTER'");
            Console.ReadLine(); 

                Console.WriteLine("Notun Geçer Kalır Hesaplaması Ve Bilgilendirmesi");
               Console.Write("Vize Notunu Giriniz: ");
               int vize = int.Parse(Console.ReadLine());
               Console.Write("Final Notunu Giriniz: ");
               int final = int.Parse(Console.ReadLine());
               int toplam=(vize + final) /2;


               if (toplam > 60 && toplam <= 100)
               {
                   Console.WriteLine(toplam + " İle Geçer");
               }
               else if (toplam >= 50 && toplam <= 60)
               {
                   Console.WriteLine(toplam + " İle Kalır");
               }
               else if (toplam < 50)
               {
                   Console.WriteLine(toplam + " İle Uzatılır");
               }
               else
               { 
               Console.WriteLine("Lütfen Geçerli Not Giriniz");
               }
               Console.WriteLine("Devam etmek için 'ENTER'");
               Console.ReadLine();

            

              Console.WriteLine("Bir sayıyı 2'lik tabana çevirmek");
            Console.WriteLine("Bir sayı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            string s = " ";

            while (sayi1>=1)
            {
                int kalan = sayi1 % 2;//Mod alma Adımını Hesapla 
                sayi1 = sayi1 / 2; //Sayıyı Bölme adımını Hesapla
                s=s+kalan;//kalanı metinsel ifadeye ekle
            }

            for (int i = s.Length-1;i>0;i--)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine("Devam etmek için 'ENTER'");
            Console.ReadLine(); 

            Console.WriteLine("1'in 64 Üssünü Alan program");
             decimal toplam=1;
             for (int i = 1; i <= 64; i++)
             {
                 toplam = toplam * 2;
                 Console.WriteLine(toplam);
             }
             Console.ReadLine();

             Console.WriteLine("0dan 100e kadar 3'e 5'e 8'e tam bölünen sayıları yazdırma");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 8 == 0 && i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

              Console.WriteLine("Faktoriyel Hesaplama");
            int i = 1;
            int carpim = 1;
            int s = Convert.ToInt32(Console.ReadLine());
            
            while (i <= s)
            { 
                carpim = carpim * i;
                i++;
            }
            Console.WriteLine(carpim);
            Console.ReadLine(); 

             Console.WriteLine("Dizi kullanarak değişken işlemleri");
             int[] fuck = new int [5];
             int toplam=0;
             Console.WriteLine("Sayı Giriniz:");
             for(int i=0;i<fuck.Length;i++)
             {Console.WriteLine(i+"/"+fuck.Length);fuck[i]=Convert.ToInt32(Console.ReadLine());}
             Console.WriteLine("Numaraları İle Dizi Değerleri");
             for(int i=0;i<fuck.Length;i++)
             {Console.WriteLine(i+":"+fuck[i]+"\n");}
             for(int i=0;i<fuck.Length;i++)
             {toplam=toplam+fuck[i];}
             Console.WriteLine("Toplamları: "+toplam);
             int min=fuck[0];
             int max=fuck[0];
             for(int i=0;i<fuck.Length;i++)
             {if(min>=fuck[i])min=fuck[i];if(max<=fuck[i])max=fuck[i];}
             Console.WriteLine("En Küçük Değer:"+ min);
             Console.WriteLine("En Büyük Değer:"+ max);
             Console.WriteLine("En Küçük Ve En Büyük Değerlerin Toplamı: "+(min+max));
             Console.WriteLine("2'ye Bölünen Tüm Değerler");
             for(int i=0;i<fuck.Length;i++)
             {if(fuck[i]%2==0)Console.WriteLine(fuck[i]);}
             Console.ReadLine();

             Console.WriteLine("Kullanıcdan girilen değeri 10 kere sıra numarası ile yazdırma");
             Console.WriteLine("Kullanıcı Adınızı Giriniz");
             string kAdi=Console.ReadLine();

             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine("Sıra Numarası:"+i+" "+kAdi);
             }
             Console.ReadLine();
            

               Console.WriteLine("6 Adet Girilen Değleri For ile toplama işlemi");
            Console.WriteLine("değer giriniz");

            int a;
            int toplam=0;
            for (int i = 0; i < 6; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + a;
                
            }Console.WriteLine(toplam);

            Console.ReadLine();

              Console.WriteLine("Kürenin Yarıçapını Hesaplama");

            Console.WriteLine("Yarıçapını Giriniz");
            int r=Convert.ToInt32(Console.ReadLine());
            // 4/3 pi r^3
            double hacim = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine(hacim);
            Console.ReadLine();

             Console.WriteLine("2 açısı verilen üçgenin 3. açısını hesaplama");

            Console.WriteLine("1. Açıyı Girin");
            int aci1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Açıyı Girin");
            int aci2 = Convert.ToInt32(Console.ReadLine());

            while (aci1 + aci2 >= 180)
            {
                Console.WriteLine("Yanlış Açılar Girdiniz Tekrar Girin");
                Console.WriteLine("1. Açıyı Girin");
                aci1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Açıyı Girin");
                aci2 = Convert.ToInt32(Console.ReadLine());
            }
            int aci3=180-(aci1 +aci2);
            Console.WriteLine(aci3);
            Console.ReadLine(); 

             Console.WriteLine("Klavyeden girilen bir sayının o sayıya kadar tek sayıların ve çift sayıların toplamı");

            Console.WriteLine("Sayı Giriniz");

            int çifttoplam = 0;
            int tektoplam = 0;
            int sayi=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayi; i= i+2)
            {
                çifttoplam = çifttoplam+ i;
            }
            for (int j = 1; j < sayi; j = j+ 2)
            {
                tektoplam = tektoplam+ j;
            }
            Console.WriteLine(tektoplam+çifttoplam);


            Console.ReadLine();

             Console.WriteLine("Ürün Fiyatı 100Tl Üstündeyse 5tl Kargo fiyatı almayan azsa 5tl ekleyen program");

            Console.WriteLine("Ürün Fiyatını Giriniz");
            int fiyat=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ürün adetini giriniz");
            int miktar = Convert.ToInt32(Console.ReadLine());
            int ToplamOdenecek=fiyat*miktar;

            if (ToplamOdenecek < 100)
            {
                ToplamOdenecek = ToplamOdenecek + 5;
                Console.WriteLine("Kargo Ücreti Çıkmaktadır.");
                Console.WriteLine(ToplamOdenecek);
            }
            else
            {
                Console.WriteLine("Kargo Ücreti Çıkmamaktadır");
                Console.WriteLine(ToplamOdenecek);
            }
            Console.ReadLine(); 

            Console.WriteLine("Hesap Makinesi");

            Console.WriteLine("1.sayıyı Giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayıyı Giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem Seçiniz");
            char op = Console.ReadKey().KeyChar;

            int sonuc = 0;
            switch (op)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc=sayi1 - sayi2;
                    break;

                case '*':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    sonuc *= sayi1 / sayi2;
                    break;
                   default:
                    Console.WriteLine("Yanlış Bir opatatör girdiniz");
                    break;
            }
            Console.WriteLine(sonuc);
            Console.ReadLine();

              Console.WriteLine("Random Komutunu Kullanarak Rastgele sayı üretme");
            Random rnd = new Random();
            int sayi = rnd.Next(1, 100);
            
            int tutulan = 30;
            int kackere = 0;
            while (true)
            {
                kackere++;
                if (tutulan == sayi)
                {
                    Console.WriteLine("Tebrikler bildin makina " + kackere);
                    break;

                }
                 sayi = rnd.Next(1, 100);
            }
            
            Console.ReadLine(); 

             Console.WriteLine("Tür Dönüşümleri");
           
            checked
            {  int a = 150;
            byte b = (byte)a;Console.WriteLine(b);

                
                    int c = 256;
                    byte d = (byte)c; Console.WriteLine(d);
                
            }
            
            Console.ReadKey();

            Console.WriteLine("Break Ve Continue");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    // 5'e geldiğinde döngünün bu adımını atla
                    continue;
                }
                else if (i == 8)
                {
                    // 8'e geldiğinde döngüyü tamamen sonlandır
                    break;
                }

                Console.WriteLine("Sayı: " + i);
            }
                Console.ReadLine(); 
            

           
        }
    }   
}
