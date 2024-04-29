using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kreta.Console.Models.SchoolCitizens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Console.Models.SchoolCitizens.Tests
{
    [TestClass()]
    public class AwardedStudentTestsIsYounger
    {
        [TestMethod()]
        public void IsYoungerTestFirstIsJunger()
        {
            AwardedStudent student1 = new AwardedStudent("Üveges Tünde", 17, 15000, false);
            AwardedStudent student2 = new AwardedStudent("Dolgozo Dénes", 18, 5000, true);
            
            bool acutal = AwardedStudent.IsYounger(student1, student2);

            Assert.IsTrue(acutal);
        }

        [TestMethod()]
        public void IsYoungerTestLastISJunger()
        {
            AwardedStudent student1 = new AwardedStudent("Üveges Tünde", 17, 15000, false);
            AwardedStudent student2 = new AwardedStudent("Dolgozo Dénes", 15, 5000, true);

            bool acutal = AwardedStudent.IsYounger(student1, student2);

            Assert.IsFalse(acutal);
        }

        [TestMethod()]
        public void IsYoungerTestBornInSameYear()
        {
            AwardedStudent student1 = new AwardedStudent("Üveges Tünde", 17, 15000, false);
            AwardedStudent student2 = new AwardedStudent("Dolgozo Dénes", 17, 5000, true);

            bool acutal = AwardedStudent.IsYounger(student1, student2);

            Assert.IsFalse(acutal);
        }
    }
}