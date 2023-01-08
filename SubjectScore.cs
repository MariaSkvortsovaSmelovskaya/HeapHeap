using System;
using System.Reflection.Metadata.Ecma335;

namespace UniversityMinsk
{
    internal class SubjectScore
    {

        private const int Max_Score = 100;
        private int _score;
        public String SubjectNames;

        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                if (value >= 0 && value <= Max_Score)
                {
                    _score = value;
                }
            }
        }
        public SubjectScore(string _subjectNames, int _score)
        {
            this.SubjectNames = _subjectNames;
            this.Score = _score;
        }

        public String getSubjectNames()
        {
            return SubjectNames;
        }
        

           
        
    }

 }