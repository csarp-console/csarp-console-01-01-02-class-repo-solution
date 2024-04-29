using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Console.Models.SchoolCitizens
{
    public class AwardedStudent
    {
        public AwardedStudent(string name, int age, int scholarship, bool montlyScholarchip)
        {
            Name = name;
            Age = age;
            Scholarship = scholarship;
            MontlyScholarchip = montlyScholarchip;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int Scholarship { get; set; }
        public bool MontlyScholarchip { get; set; }

        public bool IsAdult => Age > 18;

        public static bool IsYounger(AwardedStudent student1, AwardedStudent student2)
        {
            if (student1.Age < student2.Age)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            string montly = "Az ösztöndíj egyszeri juttatás!";
            if (MontlyScholarchip)
                montly = "Az ösztöndíj havi juttatás!";                
            return $"{Name} {Age} éves és {Scholarship} Ft ösztöndíjat nyert! {montly}";
        }

    }
}
