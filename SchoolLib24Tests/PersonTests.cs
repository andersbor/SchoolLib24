namespace SchoolLib24.Tests
{
    [TestClass()]
    public class PersonTests
    {
        private Person person;

        [TestInitialize]
        public void TestInitialize()
        {
            person = new Person(1, "B", GenderType.Male);
        }

        [TestMethod()]
        public void PersonOrdinaryConstructorTest()
        {
            Assert.AreEqual(1, person.Id);
            Assert.AreEqual("B", person.Name);
            Assert.AreEqual(GenderType.Male, person.Gender);
        }

        [TestMethod]
        public void PersonNoArgsConstructorTest()
        {
            Person p = new Person();
            Assert.AreEqual(-1, p.Id);
            Assert.AreEqual("NoName", p.Name);
        }

        [TestMethod]
        public void PersonNameExceptionTest()
        {
            Assert.ThrowsException<ArgumentNullException>(() => person.Name = null);
            Assert.ThrowsException<ArgumentException>(() => person.Name = "");
        }


        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual("Id: 1, Name: B", person.ToString());
        }
    }
}