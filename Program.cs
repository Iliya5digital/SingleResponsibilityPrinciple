using System.Collections.Generic;
using System.Linq;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //как было
            Students.Old.Student studentOld = new Students.Old.Student();
            List<Students.Old.Student> studentsOld = Students.Old.Student.GetAllStudents().ToList();

            //как стало
            Students.New.Student studentNew = new Students.New.Student();
            Students.New.StudentsRepository studentsRepository = new Students.New.StudentsRepository();
            List<Students.New.Student> studentsNew = studentsRepository.GetAllStudents().ToList();
        }
    }
}
