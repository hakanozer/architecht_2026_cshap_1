namespace Architecht
{
    

    class Program
    {
        
        // main method
        // uygulama başlatıldığında ilk çalışacak olan metot
        static void Main(string[] args)
        {
            // Tek satırlı açıklama satırı
            /*
            çok satırlı
            açıklama
            alanı
            */

            // Değişken tanımlama ve değer atama
            
            // string değişken türü
            // karakter katarı
            string name = "Ali";
            string surname = "Bilmem";
            string nick = "01Ali";
            string stNumber = "100";
            Console.WriteLine(name + " " + surname);
            Console.WriteLine(nick);
            Console.WriteLine(stNumber);

            // int - tam sayı
            int age = 25;
            age = age + 10;
            Console.WriteLine(age);

            // dobule - ondalıklı değer türü
            double ondalik1 = 10.6;
            double ondalik2 = 44.5;
            double sumOndalik = ondalik1 + ondalik2;
            Console.WriteLine(sumOndalik);

            // bool - durum, true false
            bool isStudent = true;
            Console.WriteLine(isStudent);

            // Mantıksal Operatörler
            // >, <, ==, !=, =>, <=
            int data = 19;
            bool status = false;
            status = data > 18;
            Console.WriteLine("data > 18 :" + status);
            status = data < 18;
            Console.WriteLine("data < 18 :" + status);
            status = data == 19;
            Console.WriteLine("data == 19 :" + status);
            status = data != 19;
            Console.WriteLine("data != 19 :" + status);
            status = data >= 18;
            Console.WriteLine("data >= 18 :" + status);
            status = data <= 18;
            Console.WriteLine("data <= 18 :" + status);

            // karar kontrol yapıları
            // if - else if - else
            // uygulama akışını kontrol etmek için kullanılır
            if (data > 18)
            {
                // if koşulu sağlanırsa çalışacak kod bloğu
                Console.WriteLine("data 18'den büyüktür");
            }
            else
            {
                // if koşulu sağlanmazsa çalışacak kod bloğu
                Console.WriteLine("data 18'den büyük değildir");
            }

            // Mantıksal operatörler
            // && - ve, || - veya, ! - değil
            int data1 = 10;
            int data2 = 20;
            // && - ve operatörü, her iki koşulun da sağlanması gerekir
            if (data1 > 5 && data2 < 30)
            {
                Console.WriteLine("data1 > 5 ve data2 < 30");
            }else
            {
                Console.WriteLine("koşul sağlanmadı");
            }

            string email = "ali@gmail.com";
            string password = "123456";
            if (email == "ali@gmail.com" && password == "123456")
            {
                Console.WriteLine("Giriş başarılı");
            }
            else
            {
                Console.WriteLine("Giriş başarısız");
            }

            // || - veya operatörü, koşullardan birinin sağlanması yeterlidir
            if (data1 > 5 || data2 < 10)
            {
                Console.WriteLine("data1 > 5 veya data2 < 10");
            }else
            {
                Console.WriteLine("koşul sağlanmadı");
            }

            // ! - değil operatörü, koşulun sağlanmaması durumunda çalışır
            if (!(data1 > 5))
            {
                Console.WriteLine("data1 > 5 değil");
            }else
            {
                Console.WriteLine("data1 > 5");
            }


            // diziler - array
            // aynı türdeki verileri bir arada tutmak için kullanılır
            
            string[] cities = {"İstanbul", "Ankara", "İzmir", "Bursa", "Antalya", "Adana", "Trabzon", "Samsun"};
            // dizi elemanlarına erişim
            // index -> 0 dan başlar, [] ile erişilir
            Console.WriteLine(cities[0]); // İstanbul
            int count = cities.Length; // dizi uzunluğu
            Console.WriteLine("Dizi uzunluğu: " + count);
            // diziler oluşturulduktan sonra boyutları değiştirilemez
            Console.WriteLine(cities);
            cities[1] = "Eskişehir"; // Ankara yerine Eskişehir yazıldı

            // döngüler - loop
            // for döngüsü
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            Console.WriteLine("----------------------");
            // foreach döngüsü
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("----------------------");
            // break - continue
            // break - döngüyü sonlandırır
            for (int i = 0; i < 10; i++)
            {

                if (i == 1 || i == 3)
                {
                    continue; // döngünün o adımını atlar
                }

                if (i == 6)
                {
                    break; // döngüyü sonlandırır
                }
                Console.WriteLine(i);
            }

            //kullanıcıdan veri alma
            //Console.WriteLine("Lütfen adınızı giriniz: ");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Lütfen soyadınızı giriniz: ");
            //string userSurname = Console.ReadLine();
            //Console.WriteLine("Merhaba, " + userName + " " + userSurname);

            /*
            Console.WriteLine("Lütfen kullanıcı adını giriniz! ");
            string username = Console.ReadLine();
            Console.WriteLine("Lütfen şifrenizi giriniz! ");
            string userPassword = Console.ReadLine();

            if (username == "admin" && userPassword == "123456")
            {
                Console.WriteLine("Giriş başarılı");
            }
            else
            {
                Console.WriteLine("Giriş başarısız");
            } 

            Console.WriteLine("Lütfen yaşını giriniz! ");
            string userAge = Console.ReadLine();
            int ageInt = Convert.ToInt32(userAge);
            if (ageInt >= 18)
            {
                Console.WriteLine("Giriş başarılı");
            }
            else
            {
                Console.WriteLine("Giriş başarısız");
            }
            */
            Console.WriteLine("-----------------------");

            // try - catch -> hata yakalama
            /*
            try
            {
                // try bloğu içinde hata olması muhtemel kodlar yazılır
                Console.WriteLine("Lütfen yaşını giriniz! ");
                string userAge = Console.ReadLine();
                int ageInt = Convert.ToInt32(userAge);
                Console.WriteLine("Yaşınız: " + ageInt);
            }catch (Exception ex) // ex değişkeni hatanın gerçek nedenini tutar
            {
                // catch bloğu hata olduğunda çalışacak kodlar yazılır
                Console.WriteLine("Lütfen sadece tam sayı giriniz! Hata: " + ex.Message);
            }
            Console.WriteLine("This line call");
            */

        }

    }

}
