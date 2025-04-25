namespace C08_IncrementDecrementOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Artirma ve Azaltma Islemleri (Increment And Decrement Operations)
            int num = 5, number = 0;
            Console.WriteLine("1. Num: " + num + " - Number: " + number);  // Baslangic degerleri: num=5, number=0

            number = num++;  // ONEMLI: Postfix artirma islemi (num++ önce num'in mevcut degeri number'a atanir, sonra num 1 artirilir)
            Console.WriteLine("2. Num: " + num + " - Number: " + number);  // num=6, number=5 olur

            num = 5;         
            number = 0;     

            number = ++num; // ONEMLI: Prefix artirma islemi (++num önce num 1 artirilir, sonra yeni degeri number'a atanir)
            Console.WriteLine("3. Num: " + num + " - Number: " + number);  // num=6, number=6 olur

            num = num + 1;  // num degeri dogrudan 1 artirilir
            Console.WriteLine("Num(num = num + 1;): " + num);     // Output: 7

            num += 1;   // Kisaltilmis atama ile num degeri 1 artirilir
            Console.WriteLine("Num(num += 1;): " + num);          // Output: 8

            num++;  // Postfix artirma
            Console.WriteLine("Num(num++): " + num);              // Output: 9

            num--;  // Postfix azaltma
            Console.WriteLine("Num(num--): " + num);              // Output: 8

            ++num;  // Prefix artirma
            Console.WriteLine("Num(++num): " + num);              // Output: 9

            --num;  // Prefix azaltma
            Console.WriteLine("Num(--num): " + num);              // Output: 8

            Console.Read(); 
        }
    }
}

/* DIPNOT:
  Postfix (num++) ve Prefix (++num) kullanimi arasindaki fark:
  
  1. Postfix (num++): Önce degiskenin mevcut degeri kullanilir, SONRA 1 artirilir.
     Ornek: number = num++; ifadesinde, önce num'in mevcut degeri (5) number'a atanir, sonra num 1 artirilarak 6 olur.
  
  2. Prefix (++num): Önce degisken 1 artirilir, SONRA yeni degeri kullanilir.
     Ornek: number = ++num; ifadesinde, önce num 1 artirilarak 6 olur, sonra bu yeni deger (6) number'a atanir.
  
  Bu fark özellikle atama islemlerinde veya diger islemlerde degiskenin hangi degerinin kullanilacagini belirler.
*/