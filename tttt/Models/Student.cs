using System;
using System.Collections.Generic;
using System.Text;
using tttt.Exceptions;

namespace tttt.Models
{
    public class Student
    {
        private static int _id;
        public int Id { get; }
        public string Fullname
        {
            get { return Fullname; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) Fullname = value;
                else throw new NotAvaiavleException("Bosluq daxil etmeyin!!");
            }
        }
        public int Point
        {
            get { return Point; }
            set
            {
                if (value >= 100) Point = value;
                else throw new NotAvaiavleException("100");
            }
        }
        public Student()
        {
            _id++;
            Id = _id;
        }
        public Student(string fullname,int point) :this()
        {
            Fullname = fullname;
            Point = point;
        }

    }
}
