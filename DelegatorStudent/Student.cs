﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorStudent
{
    class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public Student(String name, double score)
        {
            Name = name;
            Score = score;
        }
        public override string ToString()
        {
            return Name + " : " + Score;
        }
    }
}
