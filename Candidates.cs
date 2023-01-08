using System;

namespace UniversityMinsk
{
    internal class Candidate
    {
        public Person person;
        public SubjectScore[] subjectScores;

        public Candidate(Person person, SubjectScore[] subjectScores)
        {
            this.person = person;
            this.subjectScores = subjectScores;
        }

        public Person getPerson()
        {
            return this.person;
        }

        public SubjectScore[] getsubjectScores()
        {
            return this.subjectScores;
        }

    }
      
    
}