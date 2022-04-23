using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_Task
{
    class Student
    { 
        private int numberGroup; //номер группы 
        private int studentNumberInTheGroup; //номер студента в группе
        private string lastName; //фамилия
        public string firtsName; //имя
        public string middleName; //отчество
        private int[] arrayScore = new int[5]; //оценки по 5 предметам (массив)

        //public Student() { }
        public static Student MostSuccessfulOfAll(Student stdOne, Student stdTwo, Student stdThree)
        {
            if (stdOne.AverageScore() > stdTwo.AverageScore() & stdTwo.AverageScore() > stdThree.AverageScore())
            {
                return stdOne;
            }
            if (stdTwo.AverageScore() > stdThree.AverageScore())
            {
                return stdTwo;
            }
            return stdThree;

        }
        public int SuccessfulStudent(Student student)
        {
            return AverageScore() - student.AverageScore();
        }

        public Boolean SuccessfulStudentBool(Student student)
        {
            double o1 = AverageScore();
            double o2 = student.AverageScore();
            return (o1 > o2);
        }

        public void CorrectNumberGroup()
        {
            foreach(int array in ArrayScore) {
                if (array < 4)
                {
                    NumberGroup = 0;
                }
            }
            
        }

        public int NumberGroup
        {
            get
            {
                return numberGroup;
            }
            set
            {
                if(value < 10300 | value > 10400)
                {
                    numberGroup = 0;
                }
                else
                {
                    numberGroup = value;
                }
            }
        }

        //public int StudentNumberInTheGroup { get => studentNumberInTheGroup; set => studentNumberInTheGroup = value; }
        public int StudentNumberInTheGroup { 
            get => studentNumberInTheGroup; 
            set
            {
                if (value < 0 | value > 30)
                {
                    throw new Exception(" Incorrect student number in the group ");
                }
                else
                {
                    studentNumberInTheGroup = value;
                }
            }
        }

        public int[] ArrayScore { 
            get => arrayScore; 
            set
            {
                int j = 0;
                foreach (int array in value)
                {
                    if (array > 0 & array < 11)
                    {
                        arrayScore[j++] = array;
                    }
                    else
                    {
                        arrayScore[j++] = 0;
                    }
                    if (j >= 5)
                    {
                        break;
                    }
                }
            }
        }

        /* public Student(int n_group, int n_id, string name, string patronymic, string surname, params int[] ocenka) : this(n_group, n_id, name, patronymic, surname)
        {
            int j = 0;
            foreach (int i in ocenka)
            {
                this.ocenka[j++] = i;
                if (j >= 5) break;
            }
            for (int i = 0; i < 5; i++)
            {
                if (ocenka[i] < 0 | ocenka[i] > 10)
                    throw new Exception($"Неверная оценка у студента {surname}");
                if (ocenka[i] < 4)
                {
                    this.n_group = 0;
                }
            }

        }*/

        public string LastName { get => lastName; set => lastName = value; }

        public Student() : this(0,0, "NoLastName", "NoFirstName", "NoMiddleName")
        { 

        }

        public Student(int numberGroup, int studentNumberInTheGroup, string lastName, string firtsName, string middleName)
        {
            NumberGroup = numberGroup;
            StudentNumberInTheGroup = studentNumberInTheGroup;
            LastName = lastName;
            this.firtsName = firtsName;
            this.middleName = middleName;
            
        }

        public Student(int numberGroup, int studentNumberInTheGroup, string lastName, string firtsName, string middleName, params int[] arrayScore) : this(numberGroup, studentNumberInTheGroup, lastName, firtsName, middleName)
        {
            ArrayScore = arrayScore;
        }

        public int AverageScore()
        {
            return (ArrayScore[0] + ArrayScore[1] + ArrayScore[2] + ArrayScore[3] + ArrayScore[4]) /5;
        }

        public override string ToString()
        {
            return $"number group: {NumberGroup}\n" +
                $"student number in the group: {StudentNumberInTheGroup}\n" +
                $"last name: {LastName}\n" +
                $"firts name: {firtsName}\n" +
                $"patronymic: {middleName}\n" +
                $"arrayScore: {ArrayScore[0]} {ArrayScore[1]} {ArrayScore[2]} {ArrayScore[3]} {ArrayScore[4]}";
        }
    }
}
