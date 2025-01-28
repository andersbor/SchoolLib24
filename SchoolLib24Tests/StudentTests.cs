namespace SchoolLib24.Tests
{
    [TestClass()]
    public class StudentTests
    {
        private Student student;

        [TestInitialize]
        public void TestInitialize()
        {
            student = new Student(1, "C", semester: 1);
        }

        [TestMethod()]
        public void StudentSemesterInRangeTest()
        {
            Assert.AreEqual(1, student.Semester);
            student.Semester = 5;
            Assert.AreEqual(5, student.Semester);
        }

        [TestMethod()]
        [DataRow(0)]
        [DataRow(6)]
        public void StudentOutOfRangeSemesterTest(int semester)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => student.Semester = semester);
        }

        [TestMethod]
        public void StudentNoArgsConstructorTest()
        {
            Student s = new Student();
            Assert.AreEqual(-1, s.Id);
            Assert.AreEqual("NoName", s.Name);
            Assert.AreEqual(1, s.Semester);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual("Id: 1, Name: C, Semester: 1", student.ToString());
        }
    }
}