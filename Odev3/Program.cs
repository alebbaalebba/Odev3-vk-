//vücut kit endeksi alıp doktorlara yardımcı olmaya calısan program 
// vkı = kg/ boyun karesi
public class doktorayardim
{
    struct VKI
    {
        public double hastanınKilosu;
        public double hastanınBoyu;
        public string hastanınTeshisi;

        public double endeks()
        {
            return ((hastanınKilosu) / (hastanınBoyu * hastanınBoyu));


        }


        public string KoyulanTeshis()
        {
            if (endeks() < 18.49)
            {
                return "Zayif";
            }
            else if (18.5 < endeks() && 24.99 > endeks())
            {
                return "İdeal";
            }
            else if (25 < endeks() && 29.99 > endeks())
            {
                return "Hafif Kilolu";
            }
            else if (30 < endeks())
            {
                return "OBEZ";
            }
            else
            {
                return "Problem var ";
            }
        }
        public  void EkranaYaz()
        {
            Console.Clear();
    
            Console.WriteLine($"Hastanın Kilosu : ");
            hastanınKilosu=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Hastanın Boyu : ");
            hastanınBoyu = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Hastanın Vücut Kitle Endeksi : {endeks()}");
            Console.WriteLine($"Hastanın Teşhisi : {KoyulanTeshis()}");
            YeniBirİslemİstermisiniz();

        }
      public void YeniBirİslemİstermisiniz()
        {
            Console.WriteLine("Yeni Bir İşlem İstermisiniz ? (e/h)");
            string cevap = Console.ReadLine().ToLower();
            if (cevap =="e")
            {
                kisi.EkranaYaz();

            }
            else if (cevap=="h")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız");
                YeniBirİslemİstermisiniz();
            }
        }

    }
    static VKI kisi = new VKI();
   
        public static void Main()
    {
        kisi.EkranaYaz();
        kisi.YeniBirİslemİstermisiniz();
    }
  





   
}

