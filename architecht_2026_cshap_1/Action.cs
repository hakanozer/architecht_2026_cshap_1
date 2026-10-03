namespace Architecht
{
    
    class Action
    {
        public static string data = "veri bağlantısı";
        public string ahmet = "Ahmet Bilirim";

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

        public string Join(string word, int count)
        {
            string data = "";
            for (int i = 0; i < count; i++)
            {
                data += word; 
            }
            return data;
        }

        public CustomerModel Profile()
        {
            CustomerModel customer = new CustomerModel();
            customer.Id = 1;
            customer.Name = "Selin";
            customer.Surname = "Bilirim";
            customer.Email = "selin.bilirim@example.com";
            return customer;
        }

        public void HasRole(ERole eRole)
        {
            if (eRole == ERole.ADMIN)
            {
                Console.WriteLine("Welcome Admin");
            }else if (eRole == ERole.CUSTOMER)
            {
                Console.WriteLine("Welcome Customer");
            }else if (eRole == ERole.USER)
            {
                Console.WriteLine("Welcome User");
            }else
            {
                Console.WriteLine("No Role");
            }
        }

        public void IsRole(int role)
        {
            
        }
           


    }

}