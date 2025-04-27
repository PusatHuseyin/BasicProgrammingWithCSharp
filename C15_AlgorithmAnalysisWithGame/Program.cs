namespace C15_AlgorithmAnalysisWithGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Toplama islemine yonelik bir oyun programi yazilacaktir. 
            Oyun basladiginda, rastgele 1-100 arasinda iki sayi tutulacak, 
                bu sayilar ekranda gosterilecek ve kullaniciya bu sayilarin toplami sorulacaktir. 
            Eger kullanici dogru cevap verirse "Tebrikler Bildiniz", yanlis cevap verirse "Uzgunum Bilemediniz" seklinde bir mesaj gosterilecektir.

            Her cevaptan sonra "Tekrar oynamak istiyor musunuz? (e/E)?" seklinde bir soru sorulacak ve eger kullanici "e" veya "E" ile cevap verirse oyun tekrar baslayacaktir. 
            Kullanicinin puani her dogru cevap icin 5 puan artacak, her yanlis cevap icin ise 2 puan azalacaktir.

            Oyun sonlandiginda, kullanicinin verdigi dogru cevap sayisi, yanlis cevap sayisi ve toplam puani ekranda listelenecektir.

        START
            Adım 1: Başlangıçta gerekli değişkenleri başlat
            Skor = 0
            DoğruCevapSayısı = 0
            YanlışCevapSayısı = 0
            OyunDevamEt = True

            Adım 2: Oyun döngüsüne başla (OyunDevamEt == True)
            do
            {
                Adım 3: Rastgele iki sayı üret (1 ile 100 arasında)
                Sayı1 = RastgeleSayı(1, 100)
                Sayı2 = RastgeleSayı(1, 100)
                Toplam = Sayı1 + Sayı2

                Adım 4: Sayıları ekrana yazdır
                Ekrana Yazdır "Sayilarin Toplami: ?"

                Adım 5: Kullanıcıdan cevabı al
                KullanıcıCevabı = KullanıcıdanCevapAl()

                Adım 6: Eğer kullanıcı doğru cevabı verdiyse
                if (KullanıcıCevabı == Toplam)
                {
                    Skor = Skor + 5
                    DoğruCevapSayısı = DoğruCevapSayısı + 1
                    Ekrana Yazdır "Tebrikler Bildiniz"
                }
                else
                {
                    Adım 7: Yanlış cevapsa
                    Skor = Skor - 2
                    YanlışCevapSayısı = YanlışCevapSayısı + 1
                    Ekrana Yazdır "X - Maalesef Yanlis Cevap!"
                }

                Adım 8: Kullanıcıya tekrar oynamak isteyip istemediğini sor
                Ekrana Yazdır "Tekrar Oynamak Ister misiniz? (e/E)"
                KullanıcıCevabı = KullanıcıdanCevapAl()

                Adım 9: Eğer kullanıcı "e" veya "E" ile cevap verirse
                if (KullanıcıCevabı == "e" || KullanıcıCevabı == "E")
                {
                    // OyunDevamEt = True (Oyun devam eder)
                }
                else
                {
                    // OyunDevamEt = False (Oyun biter)
                }
            }
            while (OyunDevamEt == True)

            Adım 10: Oyun bittiğinde doğru/yanlış cevap sayısı ve puanı ekrana yazdır
            Ekrana Yazdır "Dogru Cevap Sayisi: " + DoğruCevapSayısı
            Ekrana Yazdır "Yanlis Cevap Sayisi: " + YanlışCevapSayısı
            Ekrana Yazdır "Toplam Puan: " + Skor
        STOP

            Başlangıç
                Skor = 0
                DoğruCevapSayısı = 0
                YanlışCevapSayısı = 0
                OyunDevamEt = True
    
                DÖNGÜ (OyunDevamEt == True)
                    RastgeleSayilarGenereEt (1 ile 100 arasında)
                    Sayı1 = RastgeleSayı1
                    Sayı2 = RastgeleSayı2
                    Toplam = Sayı1 + Sayı2
                    Ekrana Yazdır "Sayilarin Toplami: ?"

                    KullanıcıdanCevapAl
                    Eğer (KullanıcıCevabı == Toplam)
                        Puanı 5 arttır
                        DoğruCevapSayısını 1 arttır
                        "Tebrikler Bildiniz" mesajını göster
                    Aksi takdirde
                        Puanı 2 azalt
                        YanlışCevapSayısını 1 arttır
                        "X - Maalesef Yanlış Cevap!" mesajını göster
        
                    TekrarOynamakIstediginiSor ("e/E ile tekrar oynanabilir.")
        
                    Eğer (Kullanıcı cevabı == "e" veya "E")
                        OyunDevamEt = True
                    Aksi takdirde
                        OyunDevamEt = False

                OyunBittiğinde
                    Ekrana yaz "Doğru Cevap Sayısı: (DoğruCevapSayısı)"
                    Ekrana yaz "Yanlış Cevap Sayısı: (YanlışCevapSayısı)"
                    Ekrana yaz "Toplam Puan: (Puan)"
            Sonlandır
            */

            bool isContinue = true; // Oyun devam ediyor mu?
            int score = 0, correctAnswerCount = 0, wrongAnswerCount = 0; 

            do
            {
                Random random = new Random(); // Rastgele sayi üretici
                int num1 = random.Next(1, 101); // 1-100 arasi rastgele sayi
                int num2 = random.Next(1, 101); // 1-100 arasi rastgele diger sayi
                int total = num1 + num2; // Toplam hesaplanir

                Console.WriteLine("{0} + {1} = ?", num1, num2); // Kullaniciya soru sorulur
                Console.Write("Sayilarin Toplami: ");
                int userTotal = Convert.ToInt32(Console.ReadLine()); // Kullanici cevabi alinir

                if (total == userTotal) // Dogru cevap kontrolu
                {
                    score += 5; // Dogruysa 5 puan eklenir
                    correctAnswerCount++; // Dogru cevap sayisi artar
                    Console.WriteLine("Tebrikler Bildiniz.");
                }
                else
                {
                    score -= 2; // Yanlissa 2 puan dusulur
                    wrongAnswerCount++; // Yanlis cevap sayisi artar
                    Console.WriteLine("X - Maalesef Yanlis Cevap!");
                }

                // Tekrar oynamak isteyip istemedigini sorar
                Console.Write("Tekrar Oynamak Ister misiniz? (e/E):");
                char again = char.Parse(Console.ReadLine());

                // Eger "e" veya "E" girilirse oyun devam eder
                isContinue = (again == 'e' || again == 'E');
            }
            while (isContinue); // Oyun, isContinue true oldugu surece devam eder

            Console.WriteLine("\nDogru Cevap Sayisi: {0} \nYanlis Cevap Sayisi: {1} \nPuan: {2}", correctAnswerCount, wrongAnswerCount, score);
            Console.Read();
        }
    }
}
