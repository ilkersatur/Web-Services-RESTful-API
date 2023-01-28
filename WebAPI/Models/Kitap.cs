namespace WebAPI.Models
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public decimal Fiyat { get; set; }

    }
    static class KitapDB
    {
        static List<Kitap> kitaplar = new List<Kitap>(){
                new Kitap { KitapID = 1, KitapAdi = "denme", Fiyat = 332 },
                new Kitap { KitapID = 2, KitapAdi = "desdfsde", Fiyat = 323 },
                new Kitap { KitapID = 3, KitapAdi = "sdfsfsdfe", Fiyat = 232 }
            };
        public static List<Kitap> Kitaplar()
        {
                return kitaplar;
        }

        public static void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
        }
    }
}