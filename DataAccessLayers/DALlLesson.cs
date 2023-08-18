using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayers
{
    public class DALlLesson
    {
        public static List<EntityLesson> LessonList()
        {
            List<EntityLesson> entityStudentsList = new List<EntityLesson>();
            SqlCommand commandList = new SqlCommand("Select * from Lesson_Table", Connection.con);
            if (commandList.Connection.State != ConnectionState.Open)
            {
                commandList.Connection.Open();
            }
            SqlDataReader sqlDataLesson = commandList.ExecuteReader();
            while (sqlDataLesson.Read())
            {
                EntityLesson entityLesson = new EntityLesson();
                entityLesson.Id = Convert.ToInt32(sqlDataLesson["LESSONID"].ToString());
                entityLesson.LessonName = sqlDataLesson["LESSONNAME"].ToString();
                entityLesson.Max = int.Parse(sqlDataLesson["LESSONMAXQUOTA"].ToString());
                entityLesson.Min = int.Parse(sqlDataLesson["LESSONMINQUOTA"].ToString());
                entityStudentsList.Add(entityLesson);
            }
            sqlDataLesson.Close();
            return entityStudentsList;
        }
        public static int createLessonRequest(EntityRecourseForm recourseForm)
        {
            SqlCommand commandCreateRequest = new SqlCommand("insert into RECOURSEFORM_TABLE (STDID,LESSONID) Values (@P1,@P2)", Connection.con);
            commandCreateRequest.Parameters.AddWithValue("@P1", recourseForm.StdId);
            commandCreateRequest.Parameters.AddWithValue("@P2", recourseForm.LessonId);
            if (commandCreateRequest.Connection.State != ConnectionState.Open)
            {
                commandCreateRequest.Connection.Open();
            }
            return commandCreateRequest.ExecuteNonQuery();
        }
    }
}
