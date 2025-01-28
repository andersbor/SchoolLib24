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

        public Teacher(int id, string name, GenderType gender, int salary): base(id, name, gender)
        {
            Salary = salary;
        }

        public Teacher() : this(-1, "NoName", GenderType.Other, 0) { }

        public override string ToString()
        {
            return base.ToString() + ", Salary: " + Salary;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            if (obj.GetType() != this.GetType()) return false;
            Teacher other = (Teacher)obj;
            return Id == other.Id ;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
