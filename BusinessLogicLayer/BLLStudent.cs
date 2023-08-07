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
    }
}
