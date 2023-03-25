namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public event GradeAddedDelegate GradeAdded;
        public EmployeeBase(string name, string surname) 
        { 
            this.Name = name;
            this.Surname = surname;
            

        }
        public string Name {get; set;}

        public string Surname {get; set;}

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatistics();
    }
}

