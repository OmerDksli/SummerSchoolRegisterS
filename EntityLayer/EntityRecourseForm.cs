using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityRecourseForm
    {
        private int recourseId;

        public int RecourseId
        {
            get { return recourseId; }
            set { recourseId = value; }
        }
        private int stdId;

        public int StdId
        {
            get { return stdId; }
            set { stdId = value; }
        }
        private int lessonId;

        public int LessonId
        {
            get { return lessonId; }
            set { lessonId = value; }
        }
    }
}
