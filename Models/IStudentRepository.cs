using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyASP.NetCoreDemo.Models
{
        public interface IStudentRepository
        {
                Student GetStudent(int ID);
        }
}
