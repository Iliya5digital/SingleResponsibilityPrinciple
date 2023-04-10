using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple.Students.Old
{
    //сущность "студент"
    //нарушение принципа Single Responsibility Principle
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }

        //выбрать всех студентов из БД
        public static IEnumerable<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        //выбрать конкретного студента по Id из БД
        public static Student GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        //выбрать всех студентов в определенной группе из БД
        public static IEnumerable<Student> GetStudentsByGroupId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
