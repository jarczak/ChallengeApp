namespace ChallengeApp.Tests
{

    internal class TypeTests
    {
        [Test]
        public void AreIntegersEqual()
        {
            int number1 = 1;
            int number2 = 2;

            Assert.AreNotEqual(number1, number2);

        }
        [Test]
        public void AreStringsEqual()
        {
            string str1 = "Marek";
            string srt2 = "Marek";

            Assert.AreEqual(str1, srt2);
        }
        [Test]
        public void AreObjectsEqual() 
        {
            var emp1 = new Employee("Rafał", "Kraczaj", 30);
            var emp2 = new Employee("Rafał", "Kraczaj", 30);

            Assert.AreNotSame(emp1, emp2);
        }
    }
}
