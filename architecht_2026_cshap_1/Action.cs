namespace Architecht
{
    
    class Action
    {

       // sınıfa ait tüm özellikler burada yazılır.

       // methodlar
       // iki sayıyı toplayan bir method yazalım
        public void Message()
        {
            Console.WriteLine("Message Call");
        }

        // void -> fonksiyondan geriye bir sonuç döndermiyorum
        // return -> fonksiyondan geriye ne tarz bir tür döneceğine karar verir.
        public int Sum(int num1, int num2)
        {
            int toplam = num1 + num2;
            if (toplam > 100)
            {
                toplam = toplam / 2;
            }
            return toplam;
        }
           


    }

}