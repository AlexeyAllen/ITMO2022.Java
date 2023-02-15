using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO2022.ASP.Net.ControlTask
{
    public class GradeInfo
    {
        [Key]
        public int GradeId { get; set; }
        public byte Lesson1Mark { get; set; }
        public byte Lesson2Mark { get; set; }
        public byte Lesson3Mark { get; set; }
        public byte Lesson4Mark { get; set; }
        public byte Lesson5Mark { get; set; }
        private int sum;
        public int[] studentMarks;
        public int TotalSumMark
        {
            get { return sum; }
            set { sum = value; }
        }

        public GradeInfo() { }
        public GradeInfo(byte lesson1Mark, byte lesson2Mark, byte lesson3Mark, byte lesson4Mark, byte lesson5Mark)
        {
            Lesson1Mark = lesson1Mark;
            Lesson2Mark = lesson2Mark;
            Lesson3Mark = lesson3Mark;
            Lesson4Mark = lesson4Mark;
            Lesson5Mark = lesson5Mark;
            studentMarks = new int[] { lesson1Mark, lesson2Mark, lesson3Mark, lesson4Mark, lesson5Mark };
            sum = studentMarks.Sum();
            TotalSumMark = sum;
        }
    }
}