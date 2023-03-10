namespace ChallengeApp.Tests
{
    public class Tests
    {
     
        [Test]
        public void WhenSumOfScore_ShouldBeSumEqual()
        {
            var emp = new Employee("Rafa³", "Kraczaj", 30);
            emp.AddScore(10);
            emp.AddScore(3);
            emp.AddScore(-5);

            int result = emp.Result;
            Assert.AreEqual(8, result);

            
        }
    }
}