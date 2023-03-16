namespace ChallengeApp.Tests
{
    public class Tests
    {
     
        [Test]
        public void IfLetterInputedThenAddGrade()
        {
            var emp = new Employee("Rafa³", "Kraczaj");
            
            emp.AddGrade('c');

            var result = emp.GetStatistics();

            Assert.AreEqual(40, result.Average);
        }
        [Test]
        public void IfNumberInputedThenPrintLetter()
        {
            var emp = new Employee("Marian", "Kamiñski");
            emp.AddGrade(80);
            var result = emp.GetStatistics();

            Assert.AreEqual('A', result.AverageLetter);
        }
    }

       
}