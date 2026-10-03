using System.Text;

namespace Architecht
{
    class FileService
    {
        public string folderName = "datas";
        private readonly string _filePath;
        // kurucu method
        public FileService(string filePath)
        {
            _filePath = filePath;
            var directory = Path.GetDirectoryName(_filePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        public void Create()
        {
            if (!File.Exists(_filePath))
            {
                using (var stream = File.Create(_filePath))
                {
                    // Dosya oluşturuldu
                }
            }
        }

        public void Delete()
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }
        }

        public void WriteLine(string data)
        {
            using var writer = new StreamWriter(
                _filePath,
                append: true,
                Encoding.UTF8
            );
            writer.WriteLine(data);
        }
        
        public void AllWriteLine()
        {
            for(;;)
            {
                Console.WriteLine("Lütfen satır/data giriniz! (Kapatmak için 'e')");
                string data = Console.ReadLine();
                if (data != null && data.ToLower().Equals("e"))
                {
                    break;
                }

                if(data != null)
                {
                    WriteLine(data);
                }
                
            }
        }


        public List<string> ReadLines()
        {
            List<string> list = new();
            if (!File.Exists(_filePath))
            {
                return list;
            }

            list = File.ReadAllLines(_filePath, Encoding.UTF8).ToList();
            return list;
        }

    }
}