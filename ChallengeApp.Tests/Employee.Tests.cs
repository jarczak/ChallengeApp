namespace ChallengeApp.Tests
{
    public class Tests
    {
     
        [Test]
        public void StatisticsTest()
        {
            var emp = new Employee("Rafa³", "Kraczaj");
            emp.AddGrade(10);
            emp.AddGrade(3);
            emp.AddGrade(2.45f);

            var result = emp.GetStatistics();


            Assert.AreEqual(10, result.Max);
            Assert.AreEqual(2.45f, result.Min);
            Assert.AreEqual(5.15f, result.Average);
        }
    }
}