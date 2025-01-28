namespace SchoolLib24.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        private Teacher teacher;

        [TestInitialize]
        public void TestInitialize()
        {
            teacher = new Teacher(1, "A", 0);
        }

        [TestMethod()]
        public void TeacherOrdinaryConstructorTest()
        {
            Assert.AreEqual(1, teacher.Id);
            Assert.AreEqual("A", teacher.Name);
            Assert.AreEqual(0, teacher.Salary);
        }

        [TestMethod]
        public void TeacherSalaryExceptionTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teacher.Salary = -1);
        }

        [TestMethod()]
        public void TeacherNoArgsConstructorTest()
        {
            Teacher teacher = new Teacher();
            Assert.AreEqual(-1, teacher.Id);
            Assert.AreEqual("NoName", teacher.Name);
            Assert.AreEqual(0, teacher.Salary);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual("Id: 1, Name: A, Salary: 1", teacher.ToString());
        }
    }
}