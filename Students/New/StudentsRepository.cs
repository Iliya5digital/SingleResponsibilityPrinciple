using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple.Students.New
{
    //репозиторий студентов
    //ответственность класса - работа с базой данных
    public class StudentsRepository
    {
        //выбрать всех студентов
        public IEnumerable<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        //выбрать конкретного студента по Id
        public Student GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        //выбрать всех студентов в определенной группе
        public IEnumerable<Student> GetStudentsByGroupId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
