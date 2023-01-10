
namespace UniversityMinsk
{
    internal class Candidate
    {
        public Person person;
        public SubjectScore[] subjectScores;

        public Candidate(Person person, SubjectScore[] subjectScores)
        {
            person = person;
            subjectScores = subjectScores;
        }

        public Person GetPerson()
        {
            return person;
        }

        public SubjectScore[] GetsubjectScores()
        {
            return subjectScores;
        }

    }
      
    
}