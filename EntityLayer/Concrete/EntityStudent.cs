namespace EntityLayer.Concrete
{
    public class EntityStudent
    {
        private string name;
        private string surName;
        private int id;
        private string number;
        private string image;
        private double balance;
        private string password;

        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public int Id { get => id; set => id = value; }
        public string Number { get => number; set => number = value; }
        public string Image { get => image; set => image = value; }
        public string Password { get => password; set => password = value; }
        public double Balance { get => balance; set => balance = value; }
    }
}
