namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        public void AddGrade(float grade);
        public void AddGrade(string grade);
        public void AddGrade(char grade);
        public Statistics GetStatistics();

    }
}
