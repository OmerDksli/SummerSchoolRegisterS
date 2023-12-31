﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityLesson
    {
        private string lessonName;

        public string LessonName
        {
            get { return lessonName; }
            set { lessonName = value; }
        }
        private int min;

        public int Min
        {
            get { return min; }
            set { min = value; }
        }
        private int max;

        public int Max
        {
            get { return max; }
            set { max = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
