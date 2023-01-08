using UniversityMinsk;
/*using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/


/*namespace UniversityMinsk
{
    static void Main(string[] args)*/
    {
        Candidate[] candidates = new Candidate[7];
        Address address = new Address("Minsk", "Staletava", 18, 24);
        Person person = new Person("Hanna", "Ivanova", address);
        SubjectScore subjectscore1 = new SubjectScore("Math", 90);
        SubjectScore subjectscore2 = new SubjectScore("History", 72);
        SubjectScore subjectscore3 = new SubjectScore("Biology", 85);
        SubjectScore subjectscore4 = new SubjectScore("Language", 89);
        SubjectScore subjectscore5 = new SubjectScore("Chemistry", 92);
        SubjectScore[] subjectScorec0 = { subjectscore1, subjectscore2, subjectscore3, subjectscore4, subjectscore5 };
        candidates[0] = new Candidate(person, subjectScorec0);

        address = new Address("Minsk", "Gintovta", 64, 65);
        person = new Person("Hanna", "Ivanova", address);
        subjectscore1 = new SubjectScore("Math", 95);
        subjectscore2 = new SubjectScore("History", 76);
        subjectscore3 = new SubjectScore("Biology", 83);
        subjectscore4 = new SubjectScore("Language", 87);
        subjectscore5 = new SubjectScore("Chemistry", 79);
        SubjectScore[] subjectScorec1 = { subjectscore1, subjectscore2, subjectscore3, subjectscore4, subjectscore5 };
        candidates[1] = new Candidate(person, subjectScorec0);

        address = new Address("Brest", "Sovetskava", 16, 48);
        person = new Person("Sasha", "Sapega", address);
        subjectscore1 = new SubjectScore("Math", 100);
        subjectscore2 = new SubjectScore("History", 98);
        subjectscore3 = new SubjectScore("Biology", 99);
        subjectscore4 = new SubjectScore("Language", 97);
        subjectscore5 = new SubjectScore("Chemistry", 100);
        SubjectScore[] subjectScorec2 = { subjectscore1, subjectscore2, subjectscore3, subjectscore4, subjectscore5 };
        candidates[2] = new Candidate(person, subjectScorec0);

        address = new Address("Gomel", "Kalinouskaga", 11, 101);
        person = new Person("Yana", "Koma", address);
        subjectscore1 = new SubjectScore("Math", 77);
        subjectscore2 = new SubjectScore("History", 70);
        subjectscore3 = new SubjectScore("Biology", 65);
        subjectscore4 = new SubjectScore("Language", 84);
        subjectscore5 = new SubjectScore("Chemistry", 74);
        SubjectScore[] subjectScorec3 = { subjectscore1, subjectscore2, subjectscore3, subjectscore4, subjectscore5 };
        candidates[3] = new Candidate(person, subjectScorec0);

        address = new Address("Grodno", "Rakovskaya", 79, 21);
        person = new Person("Peter", "Skipor", address);
        subjectscore1 = new SubjectScore("Math", 95);
        subjectscore2 = new SubjectScore("History", 76);
        subjectscore3 = new SubjectScore("Biology", 83);
        subjectscore4 = new SubjectScore("Language", 87);
        subjectscore5 = new SubjectScore("Chemistry", 79);
        SubjectScore[] subjectScorec4 = { subjectscore1, subjectscore2, subjectscore3, subjectscore4, subjectscore5 };
        candidates[4] = new Candidate(person, subjectScorec0);

        for (int i = 0; i < 5; i++)
        {
            String street = candidates[i].getPerson().getAddress().getStreet();
            Console.WriteLine(street);
        }

        int maxValue = 0;
        String subjectname = "Chemistry";

        for (int i = 0; i < 5; i++)
        {
            SubjectScore[] _scores = candidates[i].getsubjectScores();
            for (int s = 0; s < 5; s++)
            {
                String subjectName = _scores[s].getSubjectNames();

                if (subjectname == subjectName)
                {
                    int score = _scores[s].Score;
                    if (score > maxValue)
                    {
                        maxValue = score;
                    }


                }
            }
        }
    }

            
