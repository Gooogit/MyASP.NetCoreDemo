﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyASP.NetCoreDemo.Models
{
        /// <summary>
        /// 学生模型
        /// </summary>
        public class Student
        {
                public int ID { get; set; }
                public string Name { get; set; }
                public string ClassName { get; set; }
                public string Email { get; set; }

        }
}
