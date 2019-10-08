using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyASP.NetCoreDemo.Models
{
        public class MockStudentRepository : IStudentRepository
        {
                private List<Student> _StudentList;

                public MockStudentRepository()
                {
                        _StudentList = new List<Student>() {
                                new Student(){ ID=1,Name="张三",ClassName="一年级",Email="zhangsan@gmail.com"},
                                new Student(){ ID=1,Name="李四",ClassName="二年级",Email="lisi@gmail.com"},
                                new Student(){ ID=1,Name="王二麻子",ClassName="三年级",Email="wangermazi@gmail.com"}
                        };
                }


                public Student GetStudent(int ID)
                {
                        return _StudentList.FirstOrDefault(a => a.ID == ID);
                }
        }
}
