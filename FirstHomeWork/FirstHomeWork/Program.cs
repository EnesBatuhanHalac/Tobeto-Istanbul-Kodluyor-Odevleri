//1 - Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.Input için Scanner kullanınız

// NOT: HOCAM siz adet ile ilgili birşey söylememişdiniz ben kendim daha güzel olur diye eklemek istedim..İf yapısı kullanmayin  dediğiniz için adet kontrolü yaparken swich-case yapısı kullandim.


//string[] productList = new string[] {"Çıkış", "Su", "Yağ", "Çikolata", "Un", "Ayakkabı" };
//Console.WriteLine("Ürünlerimiz");
//Console.WriteLine("---------------------------------------");
//Console.WriteLine("1-Su");
//Console.WriteLine("2-Yağ");
//Console.WriteLine("3-Çikolata");
//Console.WriteLine("4-Un");
//Console.WriteLine("5-Ayakkabı");
//Console.WriteLine("0- Çıkış");
//Console.WriteLine();
//Console.WriteLine("-----------------------------------------");
//Console.WriteLine("Bir Ürün Numarası Seçiniz");
//int product = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Bir Urun Adedi Giriniz");
//int piece=Convert.ToInt32(Console.ReadLine());

//    switch(piece)
//{
//    case 0:
//        Console.WriteLine("Yanlış adet girdiniz lütfen tekrar deneyiniz");
//        break;

//    default:
//        switch (product)
//        {
//            case 0:

//                Console.WriteLine("Tekrar Ziyaret etmeniz umudu ile iyi günler dileriz...");
//                break;
//            case 1:
//                Console.WriteLine(piece + " adet " + productList[product] + " Siparişiniz alınmıştır. ");
//                break;
//            case 2:
//                Console.WriteLine(piece + " adet " + productList[product] + " Siparişiniz alınmıştır. ");
//                break;
//            case 3:
//                Console.WriteLine(piece + " adet " + productList[product] + " Siparişiniz alınmıştır. ");
//                break;
//            case 4:
//                Console.WriteLine(piece + " adet " + productList[product] + " Siparişiniz alınmıştır. ");
//                break;

//            case 5:
//                Console.WriteLine(piece + " adet " + productList[product] + " Siparisiniz alınmıştır. ");
//                break;

//            default:
//                Console.WriteLine("Lütfen Geçerli Bir ürün Numarası Giriniz.");
//                break;
//        }
//        break;
//}



//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//2- kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(Input için Scanner ve döngü için for döngüsü kullanınız...)


//int[] priceList = new int[] { 10900, 25200, 8250, 2500, 18000, 25000, 3000 };
//Console.WriteLine("Tobeto Teklonoji AVM Ben Teklonoji Robotunuz Enes Hoş Geldiniz Ürünlerimiz...");
//Console.WriteLine("-------------------------------------------------");
//Console.WriteLine("0-) Çıkış");
//Console.WriteLine("1-) Xiamo Tell Me 5X 720 Px Fiyat: 10 900 TL");
//Console.WriteLine("2-) Casper Excalibur Fiyat: 25 200 TL");
//Console.WriteLine("3-) Samsung G Z25 Fiyat:8 250 Tl");
//Console.WriteLine("4-) Filtre Kahve Makinası Fiyat:2 500 TL");
//Console.WriteLine("5-) Vestel Fırın Fiyat: 18 000 TL");
//Console.WriteLine("6-) Apple Tablet Fiyat: 25 000 TL");
//Console.WriteLine("7-) Huawei Watch Akıllı Saat Fiyat: 3 000 TL");

//Console.WriteLine("-----------------------------------------------------------------------------------");
//Console.WriteLine("Satın Almak İstediginiz Adet Numarasını Tuşlayınız...");
//int piece = Convert.ToInt32(Console.ReadLine());
//int totalPrice = 0;

//switch(piece)
//{
//    case < 0:
//        Console.WriteLine("Yanlış Tercih Lütfen Tekrar Kontrol Ediniz..");
//        Console.WriteLine("Çıkışa Yönlendiriliyorsunuz.");
//        break;
//    case 0:
//        Console.WriteLine("Çıkış Yapıldı...");
//        break;
//    default:
//        for (int i = 0; i < piece; i++)
//        {

//            Console.WriteLine("-------------------------------------------------");
//            Console.WriteLine("0-) Çıkış");
//            Console.WriteLine("1-) Xiamo Tell Me 5X 720 Px Fiyat: 10 900 TL");
//            Console.WriteLine("2-) Casper Excalibur Fiyat: 25 200 TL");
//            Console.WriteLine("3-) Samsung G Z25 Fiyat:8 250 Tl");
//            Console.WriteLine("4-) Filtre Kahve Makinası Fiyat:2 500 TL");
//            Console.WriteLine("5-) Vestel Fırın Fiyat: 18 000 TL");
//            Console.WriteLine("6-) Apple Tablet Fiyat: 25 000 TL");
//            Console.WriteLine("7-) Huawei Watch Akıllı Saat Fiyat: 3 000 TL");

//            Console.WriteLine("-----------------------------------------------------------------------------------");

//            Console.WriteLine("Satın Almak istediğiniz Ürünün Numarasını Tuşlayınız...");
//            int product = Convert.ToInt32(Console.ReadLine());
//            if(product <= 0)
//            {
//                Console.WriteLine("Yanlis ürün seçimi Çıkışa Yönlendiriliyorsunuz...");
//                return;


//            }
//            totalPrice += priceList[product - 1];

//        }

//        Console.WriteLine("Toplam Fiyat: " + totalPrice + " TL");
//        break;
//}



//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//3 - Do - While ve While döngüsü nedir? Bununla ilgili örnek yapınız.


//Do While :ilk olarak Do Bölümündeki Süslü parantezlerin içerisindeki görevleri yerine getirip sonra while ile kosulun true veya false dönmesine göre tekrar Do'bölümüne geri döndügümüz döngü çeşitidir.Bir defa Kesin olarak Çalışır.

//While ise kosul False dönene kadar kendini tekrar eden döngü çeşitidir.


//int count = 1;

//do while

//do
//{
//    Console.WriteLine("Do-While Count: " + count);
//    count++;
//}
//while (count <= 15);


//while

//while(count <50)
//{
//    Console.WriteLine("While Count: " + count);
//    count += 2;
//}


//4-Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin etmesini isteyen ve doğru tahmin edene kadar devam eden bir program yazınız.(While döngüsü ile yapınız ve rastgele sayı üretmek için Random sınıfını kullanınız)


//Random randomNumber = new Random();
//int number = randomNumber.Next(1, 10);
//Console.WriteLine("Tahmini Bir sayi degeri giriniz");
//int forecast = Convert.ToInt32(Console.ReadLine());

//while(forecast != number)
//{
//    Console.WriteLine("Yanlış Tahimin Yeniden Dene");
//    forecast = Convert.ToInt32(Console.ReadLine());
//    if(forecast == number)
//    {
//        Console.WriteLine("Tebrikler Dogru Tahmin..");
//    }
//}

//5 - Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

//Console.WriteLine("Write a Number");
//int number = Convert.ToInt32(Console.ReadLine());
//int total= 0;
//for (int i = 1; i < number; i++)
//{
//    if (number % i == 0)
//    {
//        total = total + i;
//    }
//}
//if (total == number)
//{
//    Console.WriteLine(number + "sayı Mükemmel Sayıdır");
//}
//else
//{
//    Console.WriteLine(number + "sayı Mükemmel Sayı Değildir");
//}

//6 - String metotlarını araştırınız. Her bir metot için örnek yapınız.

//string isim = "Enes Batuhan Halaç";
//Replace Metot'u Verdiginiz ifadenin yerine yeni verdiginiz string ifadeyi koyar.
//Console.WriteLine(isim.Replace("Enes", "Ahmet"));
//ToLower verilen string ifade içerisindeki bütün harfleri küçültür.
//Console.WriteLine(isim.ToLower());
// To Upper verilen string ifade içerisindeki bütün harfleri Büyültür.
//Console.WriteLine(isim.ToUpper());
// IndexOf Verdigin kelimenin metinsel ifade içerisindeki indexini verir.Bosluklar sayilmaz
//Console.WriteLine(isim.IndexOf("a"));
// Clone metodu string ifadenin clonunu cikartir yeni degiskene atar.
//string isim2=(string)isim.Clone();
//Console.WriteLine(isim2);
//Contains metodu string ifade içerisinde verdigin ifadeyi arar var ise true yok ise false döner.
//Console.WriteLine(isim.Contains("Bat"));
//Insert metodu 2 adet string ifadeyi birleştirir.
//string isim3 = "E.Batuhan";
//string metin2 = "Halac";
//Console.WriteLine(isim3.Insert(9, metin2));
//Remove metodu belirtilen index degerinden başlayarak sonuna kadar siler eger 2 adet sayi verir isek biri baslangic indexi digeri Baslangicdan itibaren kaç index silinecegini belirtir.
//Console.WriteLine(isim3.Remove(2,4));
//Console.WriteLine(isim3.Remove(4));

//Split methodu belirtilen karaktere göre metni bölme işlemi yapar
//string metin = "Enes,Batuhan,1997";
//string[] dizi = metin.Split(',');

//for (int i = 0; i < dizi.Length; i++)
//{
//    Console.WriteLine(dizi[i]);
//}

//Trim Methodu String değişkeni içerisinde ki metnin başlangıcındaki ve bitişindeki boşlukları kaldırır.
//string isim4 = "  Enes Batuhan    ";
//Console.WriteLine(isim4);
//Console.WriteLine(isim4.Trim());


//substring methodu belirtilen indexten itibaren o metni alir.2. sayi verir isek 2. sayi adedi kadar alır.

//Console.WriteLine(isim.Substring(5,7));

//metotta verilen sayisal degerden metnin bosluklar dahil uzunlugu cikartilir ve kalan sayi kadar sag tarafa ekleme yapilir.
//string metin5 = "Enes Batuhan Halaç";
//Console.WriteLine(metin5.PadRight(20, 'a'));

//metotta verilen sayisal degerden metnin bosluklar dahil uzunlugu cikartilir ve kalan sayi kadar sol tarafa ekleme yapilir.

//Console.WriteLine(metin5.PadLeft(20, 'a'));