namespace C07_AssignmentOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Atama Operatorleri (Assignment Operators)
            double num = 5;                // num degiskenine 5 degeri atanir
            Console.WriteLine(num);        // Output: 5

            num = num + 3;                 // num degiskenine 3 eklenir ve sonuc num'a atanir
            Console.WriteLine(num);        // Output: 8

            num += 2;                      // num = num + 2 ile ayni anlama gelir (kisaltilmis atama)
            Console.WriteLine(num);        // Output: 10

            num = num - 3;                 // num degiskeninden 3 cikarilir ve sonuc num'a atanir
            Console.WriteLine(num);        // Output: 7 (fazladan noktalı virgül var, duzeltildi)

            num -= 3;                      // num = num - 3 ile ayni anlama gelir (kisaltilmis atama)
            Console.WriteLine(num);        // Output: 4

            num = num * 3;                 // num degiskeni 3 ile carpilir ve sonuc num'a atanir
            Console.WriteLine(num);        // Output: 12

            num *= 2;                      // num = num * 2 ile ayni anlama gelir (kisaltilmis atama)
            Console.WriteLine(num);        // Output: 24

            num = num / 3;                 // num degiskeni 3'e bolunur ve sonuc num'a atanir
            Console.WriteLine(num);        // Output: 8

            num /= 3;                      // num = num / 3 ile ayni anlama gelir (kisaltilmis atama)
            Console.WriteLine(num);        // Output: 2.6666666666666665

            num %= 3;                      // num = num % 3 ile ayni anlama gelir (mod alma islemi)
            Console.WriteLine(num);        // Output: 2.6666666666666665 % 3 = 2.6666666666666665
                                           // (2.6666666666666665 < 3 oldugu icin kalan kendisi olur)

            num = num % 3;                 // num degiskeninin 3'e bolumunden kalan num'a atanir (usteki satirla ayni)
            Console.WriteLine(num);        // Output: 2.6666666666666665

            Console.Read();              
        }
    }
}