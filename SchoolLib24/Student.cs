namespace SchoolLib24
{

    public class Student : Person
    {
        private int _semester;

        public int Semester
        {
            get => _semester;
            set
            {
                if (value < 1 || value > 5) throw new ArgumentOutOfRangeException("semester is out of range: " + value);
                _semester = value;
            }
        }

        public Student(int id, string name, GenderType gender, int semester) : base(id, name, gender)
        {
            Semester = semester;
        }

        public Student() : this(-1, "NoName", GenderType.Other, 1) { }

        public override string ToString()
        {
            return $"{base.ToString()}, Semester: {Semester}";
        }
    }
}
