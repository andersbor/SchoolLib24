namespace SchoolLib24
{
    public enum GenderType { Male, Female, Other }

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

        public GenderType Gender { get; set; }

        public Person(int id, string name, GenderType gender)
        {
            Id = id;
            Name = name;
            Gender = gender;
        }

        public Person() : this(id: -1, name: "NoName", GenderType.Other) { }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
