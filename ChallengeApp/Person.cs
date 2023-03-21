﻿namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name, string surname, string sex)
        {

            Name = name;
            Surname = surname;
            Sex = sex;

        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
    }
}
