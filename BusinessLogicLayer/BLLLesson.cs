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
    }
}
