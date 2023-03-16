namespace ChallengeApp.Tests
{
    public class Tests
    {
     
        [Test]
        public void IfLetterInputedThenAddGrade()
        {
            var emp = new Employee("Rafa�", "Kraczaj");
            
            emp.AddGrade('c');

            var result = emp.GetStatistics();

            Assert.AreEqual(40, result.Average);
        }
        [Test]
        public void IfNumberInputedThenPrintLetter()
        {
            var emp = new Employee("Marian", "Kami�ski");
            emp.AddGrade(80);
            var result = emp.GetStatistics();

            Assert.AreEqual('A', result.AverageLetter);
        }
    }

       
}