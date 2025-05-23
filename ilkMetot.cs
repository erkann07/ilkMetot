void sarkiSozu()
{
    Console.WriteLine("Görmeyeli ne çok oldu demişsin kim bilir nasıl, nicedir halin.");
}
sarkiSozu();

int bolumKalan()
{
    Random rnd = new Random();
    int rndSayi = rnd.Next(15, 100);
    Console.WriteLine("Üretilen Rastgele Sayı --> " + rndSayi);
    int bolum = rndSayi % 2;
    Console.WriteLine("2'yle Bölümünden Kalan --> " + bolum);
    return bolum;
}
bolumKalan();
int carp(int a, int b)
{
    int sonuc =a * b;
    Console.WriteLine("Çarpım Sonucu --> " + sonuc);
    return sonuc;
}
carp(5, 10);
void form()
{
    Console.WriteLine("İsminiz");
    string isim = Console.ReadLine();
    Console.WriteLine("Soyadınız");
    string soyad = Console.ReadLine();
    Console.WriteLine("Tam Adınız --> " + isim + " " + soyad);
}
form();
