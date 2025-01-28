namespace SchoolLib24
{
    public class Teacher : Person
    {
        private int salary;

        public int Salary
        {
            get => salary;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("salary is negative: " + value);
                salary = value;
            }
        }

        public Teacher(int id, string name, int salary): base(id, name)
        {
            Salary = salary;
        }

        public Teacher() : this(-1, "NoName", 0) { }

        public override string ToString()
        {
            return base.ToString() + ", Salary: " + Salary;
        }
    }
}
