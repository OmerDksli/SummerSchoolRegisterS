using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayers;
namespace BusinessLogicLayer
{
    public class BLLLesson
    {
        public static List<EntityLesson> BllLessonList()
        {
            return DALlLesson.LessonList();
        }
        public static int BllLessonRequest(EntityRecourseForm recourseForm)
        {
            if (recourseForm.LessonId!=0&&recourseForm.StdId!=0)
            {
                return DALlLesson.createLessonRequest(recourseForm);
            }
            return -1;
        }
    }
}
