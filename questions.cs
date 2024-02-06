// 1- Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.
/*
Console.WriteLine("1-Kalem 2-Çanta 3-Elma 4-Top");
Console.Write("Ürün Seçiniz: ");
int urun = Convert.ToInt32(Console.ReadLine());

switch (urun)
{
    case 1:
        Console.Write("Kalem satın alındı.");
        break;
    case 2:
        Console.Write("Çanta satın alındı.");
        break;
    case 3:
        Console.Write("Elma satın alındı.");
        break;
    case 4:
        Console.Write("Top satın alındı.");
        break;
    default:
        break;
}
*/

// 2 - kullanıcıdan kaç ürün almak istediğini soran, her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)
/*
Console.Write("Ürün Adedi Giriniz: ");
int urunAdedi = Convert.ToInt32(Console.ReadLine());

int total = 0;

for (int i = 0; i < urunAdedi; i++)
{
    Console.WriteLine("1-Kalem(12 TL) 2-Çanta(30 TL) 3-Elma(4 TL)");
    Console.Write("Ürün Seçiniz: ");
    int urun = Convert.ToInt32(Console.ReadLine());

    switch (urun)
    {
        case 1:
            total += 12;
            break;
        case 2:
            total += 30;
            break;
        case 3:
            total += 4;
            break;
        default:
            Console.WriteLine("--Geçersiz ürün seçimi.--");
            i--;
            break;
    }
}
Console.WriteLine("Toplam Tutar: " + total);
*/

// 3- Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.
/*
bool isBuyed = false;
double total = 0;
int urunAdedi = 0;
int counter = 5;

do  // do-while: koşul karşılanmasa dahi döngünün 1 kere çalışmasını sağlar.
{
    while (counter == 5) // while: koşul karşılandığı sürece çalışır.
    {
        Console.WriteLine("1-Kalem(12.50 TL) 2-Çanta(30 TL) 3-Elma(4 TL) 4-Kulaklık(74.95 TL) 5-Satın Al");
        counter = 1;
    } 

    Console.Write("Ürün Seçiniz: ");
    int urun = Convert.ToInt32(Console.ReadLine());

    if (urun != 5 && urun > 0 && urun < 6)
    {
        Console.Write("Ürün Adedi  : ");
        urunAdedi = Convert.ToInt32(Console.ReadLine());
    }
    
    counter++;

    switch (urun)
    {
        case 1:
            total += 12.50 * urunAdedi;
            break;
        case 2:
            total += 30 * urunAdedi;
            break;
        case 3:
            total += 4 * urunAdedi;
            break;
        case 4:
            total += 74.95 * urunAdedi;
            break;
        case 5:
            isBuyed = true;
            break;
        default:
            Console.WriteLine("--Geçersiz ürün seçimi.--");
            break;
    }
} while (isBuyed == false);
Console.WriteLine("Satın alım başarılı. Tutar: " + total);
*/

// 4- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.
/*
Console.Write("Mükemmel Sayı kontrolü: ");
int sayi = Convert.ToInt32(Console.ReadLine());

int toplam = 0;

for (int i = 1; i < sayi; i++)
{
    if (sayi % i == 0)
    {
        toplam += i;
    }
}

if (toplam == sayi)
{
    Console.WriteLine("Sayı, Mükemmel sayıdır.");
}
else
{
    Console.WriteLine("Sayı, Mükemmel sayı değildir.");
}
*/

// 5- String metotlarını araştırınız. Her bir metot için örnek yapınız.
/*
string sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
Console.WriteLine(sentence);

Console.WriteLine("Length: " + sentence.Length); // lenght: string uzunluk. int döndürür.

string sentence2 = "Suspendisse porttitor, libero euismod varius mattis, nulla ante dapibus ante, nec pellentesque leo libero at purus.";
Console.WriteLine("Concat: " + string.Concat(sentence, sentence2)); // concat: string verileri birleştirir.

bool result = sentence.Equals(sentence2);
Console.WriteLine("Equal: " + result); // equal: metin eşitliğini kontrol eder.

sentence.ToUpper(); // Metni büyük harflere çevirir.
sentence2.ToLower(); // Metni küçük harflere çevirir.
*/

// 6 - Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır. ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.
/*
Console.Write("Ürün Fiyatı: ");
int unitPrice = Convert.ToInt32(Console.ReadLine());

if (unitPrice < 300)
{
    unitPrice += 50;
}

Console.WriteLine("Son Tutar: " + unitPrice);
*/

// 7 - iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.
/*
Console.Write("1. Ürün Fiyatı: ");
int unitPrice1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Ürün Fiyatı: ");
int unitPrice2 = Convert.ToInt32(Console.ReadLine());

double total = unitPrice1 + unitPrice2;

if (total >= 500)
{
    total = unitPrice1 + (unitPrice2 * 0.6);
}

Console.WriteLine("Son Tutar: " + total);
*/

// 8- 1-200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.
/*
int count = 0;
for (int i = 1; i <= 200; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        Console.WriteLine(i);
        count++;
    }
}
Console.WriteLine("3'e veya 5'e tam bölünebilen sayı adedi: " + count);
*/

