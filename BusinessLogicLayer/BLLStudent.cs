using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayers;


namespace BusinessLogicLayer
{
    public class BLLStudent
    {
        public static int AddStudentBLL(EntityStudent student)
        {
            if (student.Name != null && student.Surname != null && student.Number != null && student.Image != null && student.Password != null)
            {
                return DALStudent.AddStudent(student);
            }
            return -1;
        }
        public static List<EntityStudent> BllStudentList()
        {
            return DALStudent.StudentList();
        }
        public static bool studentDeleteBLL(int delId)
        {
            if (delId>0)
            {
                return DALStudent.studentDelete(delId);
            }
            return false;
        }
        public static bool studentUpdateBLL(EntityStudent delId)
        {
            if (delId.Name!=null&& delId.Surname != null && delId.Number != null && delId.Password != null && delId.Image != null && delId.Id > 0)
            {
                return DALStudent.studentUpdate(delId);
            }
            return false;
            
        }
        public static EntityStudent BllStudentDetail(int id)
        {
            return DALStudent.StudentDetail(id);
        }
    }
}
