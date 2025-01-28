namespace SchoolLib24
{
    public class Person
    {
        public int Id { get; set; }

        private string _name;

        public string Name
        {
            get => _name; set
            {
                if (value == null) throw new ArgumentNullException("name is null");
                if (value == "") throw new ArgumentException("name is empty");
                _name = value;
            }
        }
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Person() : this(-1, "NoName") { }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
