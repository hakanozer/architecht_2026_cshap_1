using System.Collections.Generic;

namespace Architecht
{
    
    class CustomerList
    {
        
        public void Execute()
        {
            
            List<string> ls = new();

            // Add metodu ile listeye veri ekleme
            ls.Add("Ali");
            ls.Add("Veli");
            ls.Add("Ayşe");
            ls.Add("Fatma");
            ls.Add("Mehmet");
            ls.Add("Ahmet");

            // item değerini yazdırma
            //Console.WriteLine(ls[0]);

            // Count metodu ile listenin eleman sayısını öğrenme
            Console.WriteLine(ls.Count);

            // kullanıcıdan veri alıp listeye ekleme
            for(;;)
            {
                Console.WriteLine("Lütfen bir isim giriniz: (Kapat için 'e' yazın) ");
                string userInput = Console.ReadLine();
                if (userInput == "e")
                {
                    break;
                }
                ls.Add(userInput);
            }

            // insert metodu ile listenin istediğimiz indexine veri ekleme
            ls.Insert(1, "Zeynep");

            // remove metodu ile listenin istediğimiz indexindeki veriyi silme
            //ls.RemoveAt(2);
            //ls.Remove("Ayşe");

            // clear metodu ile listenin tüm elemanlarını silme
            // ls.Clear();

            // Eleman değerini değiştirme
            ls[0] = "Kenan";

            // indexof metodu ile listenin istediğimiz elemanının indexini bulma
            int index = ls.IndexOf("Fatma");
            Console.WriteLine("Fatma'nın indexi: " + index);

            // contains metodu ile listenin istediğimiz elemanı içerip içermediğini kontrol etme
            bool contains = ls.Contains("Mehmet");
            Console.WriteLine("Mehmet var mı? " + contains);

            // sort metodu ile listenin elemanlarını sıralama
            // ls.Sort();
            // ls.Reverse();

            // filterleme - where metodu ile listenin elemanlarını filtreleme
            List<string> filteredList = ls.Where( item => item.ToLower().Contains("a") ).ToList();
            Console.WriteLine("Filtrelenmiş liste:");
            foreach (string item in filteredList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------");
            // tüm elemanları yazdırma
            foreach (string item in ls)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------");
            List<CustomerModel> customerList = new();

            var customer1 = new CustomerModel() { Id = 1, Name = "Ali", Surname = "Yılmaz", Email = "ali.yilmaz@example.com" };
            var customer2 = new CustomerModel() { Id = 2, Name = "Ayşe", Surname = "Demir", Email = "ayse.demir@example.com" };
            var customer3 = new CustomerModel() { Id = 3, Name = "Mehmet", Surname = "Kaya", Email = "mehmet.kaya@example.com" };
            var customer4 = new CustomerModel() { Id = 4, Name = "Fatma", Surname = "Çelik", Email = "fatma.celik@example.com" };
            
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            customerList.Add(customer4);

            Console.WriteLine(customerList.Count);
            foreach (CustomerModel item in customerList)
            {
                Console.WriteLine(item);
                //Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Surname: {item.Surname}, Email: {item.Email}");
            }

        }


    }



}