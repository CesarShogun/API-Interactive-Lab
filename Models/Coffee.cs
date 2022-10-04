namespace API_Interactive_Lab_1.Models
{
    public class Coffee
    {
        public string Name { get; private set; }
        public int Id { get; private set; }

        public Coffee(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
