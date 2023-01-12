using UniversityMinsk;

const string subjectname = "Chemistry";

Candidate[] candidates = new Candidate[5];
var person = new Person("Hanna", "Ivanova", new Address("Minsk", "Staletava", 18, 24));
var subjectscore1 = new SubjectScore("Math", 90);
var subjectscore2 = new SubjectScore("History", 72);
var subjectscore3 = new SubjectScore("Biology", 85);
var subjectscore4 = new SubjectScore("Language", 89);
var subjectscore5 = new SubjectScore("Chemistry", 92);
 SubjectScore[] subjectScores0 = {
     subjectscore1, 
     subjectscore2, 
     subjectscore3, 
     subjectscore4, 
     subjectscore5 
 };
 candidates[0] = new Candidate(person, subjectScores0);

       
person = new Person("Dasha", "Kuznetsova", new Address("Minsk", "Gintovta", 64, 65));
subjectscore1 = new SubjectScore("Math", 95);
subjectscore2 = new SubjectScore("History", 76);
subjectscore3 = new SubjectScore("Biology", 83);
subjectscore4 = new SubjectScore("Language", 87);
subjectscore5 = new SubjectScore("Chemistry", 79);
SubjectScore[] subjectScores1 = { 
    subjectscore1, 
    subjectscore2, 
    subjectscore3, 
    subjectscore4, 
    subjectscore5 
};
candidates[1] = new Candidate(person, subjectScores1);

        
person = new Person("Sasha", "Sapega", new Address("Brest", "Sovetskava", 16, 48));
subjectscore1 = new SubjectScore("Math", 100);
subjectscore2 = new SubjectScore("History", 98);
subjectscore3 = new SubjectScore("Biology", 99);
subjectscore4 = new SubjectScore("Language", 97);
subjectscore5 = new SubjectScore("Chemistry", 100);
SubjectScore[] subjectScores2 = { 
    subjectscore1, 
    subjectscore2, 
    subjectscore3, 
    subjectscore4, 
    subjectscore5 
};
candidates[2] = new Candidate(person, subjectScores2);

        
person = new Person("Yana", "Koma", new Address("Gomel", "Kalinouskaga", 11, 101));
subjectscore1 = new SubjectScore("Math", 77);
subjectscore2 = new SubjectScore("History", 70);
subjectscore3 = new SubjectScore("Biology", 65);
subjectscore4 = new SubjectScore("Language", 84);
subjectscore5 = new SubjectScore("Chemistry", 74);
SubjectScore[] subjectScores3 = { 
    subjectscore1, 
    subjectscore2, 
    subjectscore3, 
    subjectscore4, 
    subjectscore5 
};
candidates[3] = new Candidate(person, subjectScores3);

        
person = new Person("Peter", "Skipor", new Address("Grodno", "Rakovskaya", 79, 21));
subjectscore1 = new SubjectScore("Math", 95);
subjectscore2 = new SubjectScore("History", 76);
subjectscore3 = new SubjectScore("Biology", 83);
subjectscore4 = new SubjectScore("Language", 87);
subjectscore5 = new SubjectScore("Chemistry", 79);
SubjectScore[] subjectScores4 = { 
    subjectscore1, 
    subjectscore2, 
    subjectscore3, 
    subjectscore4, 
    subjectscore5 
};
candidates[4] = new Candidate(person, subjectScores4);

for (var i = 0; i < 5; i++)
{
    var street = candidates[i].Person.Address.Street;
    Console.WriteLine(street);
}

var maxValue = 0;


for (int i = 0; i < 5; i++)
{
    SubjectScore[] _scores = candidates[i].SubjectScores;
    for (int s = 0; s < 5; s++)
    {
        string subjectName = _scores[s].SubjectName;

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

    Console.WriteLine(maxValue);



            
