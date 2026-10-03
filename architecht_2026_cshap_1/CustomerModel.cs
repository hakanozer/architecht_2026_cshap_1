namespace Architecht
{

    class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        override public string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Surname: {Surname}, Email: {Email}";
        }

    }

}