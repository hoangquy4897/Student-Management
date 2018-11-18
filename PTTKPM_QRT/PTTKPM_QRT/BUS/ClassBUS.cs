using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.BUS
{
    class ClassBUS
    {
        // Get list class by grade
        public static List<Classes> GetListClasses(string grade)
        {
            Console.WriteLine("Loading list classes by grade " + grade + " ...");
            List<Classes> classes = DAO.ClassDAO.Instance.GetListClass(grade);
            Console.WriteLine("Loading list classes success!");

            return classes;
        }

        // Adding list student to class
        public static void AddStudentToClass(int grade, int numberOfStudent, string classID)
        {
            Console.WriteLine("Adding student to class " + grade + classID + " ...");
            DAO.ClassDAO.Instance.AddStudentToClass(grade, numberOfStudent, classID);
            Console.WriteLine("Adding student to class success!");
        }
    }
}
