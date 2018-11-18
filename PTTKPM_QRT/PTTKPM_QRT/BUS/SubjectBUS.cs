using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.BUS
{
    class SubjectBUS
    {
        // Get list subject
        public static List<Subject> GetListSubject()
        {
            Console.WriteLine("Loading list subject....");
            return DAO.SubjectDAO.Instance.GetListSubject();
        }

        // Add subject
        public static void AddSubject(Subject subject)
        {
            Console.WriteLine("Adding subject " + subject.Name + " ...");
            DAO.SubjectDAO.Instance.AddSubject(subject);
            Console.WriteLine("Add subject " + subject.Name + " success!");
        }

        // Delete subject
        public static void DeleteSubject(Subject subject)
        {
            Console.WriteLine("Deleting subject " + subject.Name + " ...");
            DAO.SubjectDAO.Instance.DeleteSubject(subject);
            Console.WriteLine("Delete subject " + subject.Name + " success!");
        }
    }
}
