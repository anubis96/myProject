using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject
{
    class Modules
    {
        
        public string Code_Module { get; set; }
        public string Name_Module { get; set; }
        public int Number_Credit { get; set; }
        public int Class_HourWeeks { get; set; }
        public int NOTW { get; set; }
        public string DSOF { get; set; }
        public int Number_self_study { get; set; }
        public int Spend_Hour { get; set; }
        public int Remain_Self_Hour { get; set; }


        /*public Modules(string code, string name, int credit, int hourWeek, int number_of_the_weeks, string date_start, int self_study, int Hspend, int remain)
        {
            Semester sem = new Semester();
            number_of_the_weeks = sem.numberOfWeeks;
            date_start = sem.dateStartofSemester;

            Code_Module = code;
            Name_Module = name;
            Number_Credit = credit;
            Class_HourWeeks = hourWeek;
            NOTW = number_of_the_weeks;
            DSOF = date_start;
            Number_self_study = self_study;
            Spend_Hour = Hspend;
            Remain_Self_Hour = remain;
        }*/

        public void DisplayModules()
        {
            Console.WriteLine("Code: " + Code_Module);
            Console.WriteLine("Name: " + Name_Module);
            Console.WriteLine("Credit: " + Number_Credit);
            Console.WriteLine("Hour: " + Class_HourWeeks);

        }
 
    }

}
