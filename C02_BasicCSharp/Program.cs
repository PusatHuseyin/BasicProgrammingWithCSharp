using System.Runtime.InteropServices; // Disaridaki DLL kutuphaneleri ve platformlar arasi kod cagirma islemleri icin gerekli

namespace C02_BasicCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Farkli veri tiplerinde degisken tanimlama ve baslangic deger atama
            // Format: degiskenTipi degiskenAdi = degiskenDegeri;
            char character = 'c';           //  karakter - 2 byte
            string name = "Ali";            // karakter dizisi - 4*2 byte (Her karakter 2 byte yer kaplar)
            int integerNumber = 15;         // tam sayi - 4 byte
            float fractionalNumber = 3.14F; // 4 byte (F son eki float tipini belirtir)
            double decimalNumber = 14.8;    // 8 byte (float'tan daha yuksek hassasiyet)
            bool key = true;                // 1 byte !(ancak genellikle 4 byte dolgu kullanilir)
                                            // int num = 8;                 // Yorum satiri haline getirilmis degisken

            // Console.Write metodu kullanimi - tum degerleri tek satirda yazdirir ve sonunda yeni satir karakteri ekler
            Console.Write(character + " " + name + " " + integerNumber + " " + fractionalNumber + " " + decimalNumber + " " + key + "\n");

            // Console.WriteLine metodu kullanimi - otomatik olarak sonunda yeni satir ekler
            Console.WriteLine(character + " " + name + " " + integerNumber + " " + fractionalNumber + " " + decimalNumber + " " + key);

            // Degisken degerlerini farkli yontemlerle gosterme
            // Yontem 1: String birlestirme kullanarak
            Console.WriteLine("Integer Number: " + integerNumber + "\n" + "'Key' Value: " + key);

            // Yontem 2: String formatlama ve yer tutucular kullanarak
            Console.WriteLine("Integer Number: {0} \n'Key' Value: {1}\n", integerNumber, key);

            // Marshal.SizeOf() kullanarak degiskenlerin bellek boyutunu ogrenme
            int boolSizeof = Marshal.SizeOf(fractionalNumber);
            int decimalSizeof = Marshal.SizeOf(decimalNumber);
            int fractionalSizeof = Marshal.SizeOf(fractionalNumber);
            Console.WriteLine("Size of a fractional number: {0}", fractionalSizeof);
            Console.WriteLine("Size of a Boolean: {0}", boolSizeof);
            Console.WriteLine("Size of a Decimal Number: {0}\n", decimalSizeof);

            // sizeof operatorunu kullanarak ilkel veri tiplerinin byte cinsinden boyutunu ogrenme
            Console.WriteLine("'Integer' Sizeof: {0}", sizeof(int));
            Console.WriteLine("'Float' Sizeof: {0}", sizeof(float));
            Console.WriteLine("'Double' Sizeof: {0}", sizeof(double));
            Console.WriteLine("'Boolean' Sizeof: {0}", sizeof(bool));
            Console.WriteLine("'Char' Sizeof: {0}", sizeof(char));

            // String'in bellek boyutunu hesaplama (karakter sayisi * char boyutu)
            Console.WriteLine("'String' Sizeof ((character length of the word) * 2): {0}", name.Length * sizeof(char));

            Console.Read();
        }
    }
}