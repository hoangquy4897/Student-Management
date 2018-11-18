using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.BUS
{
    class StudentBUS
    {
        // Add a student
        public static void AddStudent(Student student)
        {
            Console.WriteLine("Check student " + student.Name + " ...");

            if (DAO.StudentDAO.Instance.CheckStudent(student) == false)
            {
                Console.WriteLine("Student " + student.Name + " is not available!");
                Console.WriteLine("Loading....");

                DAO.StudentDAO.Instance.AddStudent(student);
                Console.WriteLine("Add student " + student.Name + " success!");
            }
            else
            {
                Console.WriteLine("Student " + student.Name + " is not available!");
                Console.WriteLine("Add student " + student.Name + " fail!");
            }
        }

        // Delete a student by student id
        public static void DeleteStudent(int id)
        {
            Console.WriteLine("Check student id " + id + " ...");

            if(DAO.StudentDAO.Instance.CheckStudent(id) == true)
            {
                Console.WriteLine("Student id " + id + " is available!");
                DAO.StudentDAO.Instance.DeleteAbsent(id);
                DAO.StudentDAO.Instance.DeleteStudent(id);
                Console.WriteLine("Delete student id " + id + " success!");
            }
            else
            {
                Console.WriteLine("Student id " + id + " is not available!");
                Console.WriteLine("Delete student id " + id + " fail!");
            }
        }

        // Update student information
        public static void UpdateStudentInformation(int studentID, string name, string gender, string birthday, string address, int grade, string phoneNumber)
        {
            Console.WriteLine("Starting update student information...");
            BUS.StudentBUS.UpdateStudentInformation(studentID, name, gender, birthday, address, grade, phoneNumber);
            Console.WriteLine("Update student information success!");
        }
    }
}
