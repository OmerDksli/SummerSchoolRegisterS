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
    public class DALStudent
    {
        public static int AddStudent(EntityStudent student)
        {
            SqlCommand command = new SqlCommand("insert into Student_Table (StdName,StdSurname," +
                "StdNumber,StdImage,StdPassword) values (@p1,@p2,@p3,@p4,@p5)", Connection.con);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@p1", student.Name);
            command.Parameters.AddWithValue("@p2", student.Surname);
            command.Parameters.AddWithValue("@p3", student.Number);
            command.Parameters.AddWithValue("@p4", student.Image);
            command.Parameters.AddWithValue("@p5", student.Password);
            

            return command.ExecuteNonQuery();//etkilenen kayıt sayısı geri döndürülür
        }
        public static List<EntityStudent> StudentList()
        {
            List<EntityStudent> entityStudentsList = new List<EntityStudent>();
            SqlCommand commandList = new SqlCommand("Select * from Student_Table", Connection.con);
            if (commandList.Connection.State != ConnectionState.Open)
            {
                commandList.Connection.Open();
            }
            SqlDataReader sqlDataStudent = commandList.ExecuteReader();
            while (sqlDataStudent.Read())
            {
                EntityStudent student = new EntityStudent();
                student.Id = Convert.ToInt32(sqlDataStudent["STDID"].ToString());
                student.Name = sqlDataStudent["STDNAME"].ToString();
                student.Surname = sqlDataStudent["STDSURNAME"].ToString();
                student.Number = sqlDataStudent["STDNUMBER"].ToString();
                student.Password = sqlDataStudent["STDPASSWORD"].ToString();
                student.Image = sqlDataStudent["STDIMAGE"].ToString();
                student.Balance = Convert.ToDouble(sqlDataStudent["STDBALANCE"].ToString());
                entityStudentsList.Add(student);
            }
            sqlDataStudent.Close();
            return entityStudentsList;
        }
        public static EntityStudent StudentDetail(int id)
        {
           
            SqlCommand commandDetail = new SqlCommand("Select * from Student_Table Where StdId=@p1", Connection.con);
            if (commandDetail.Connection.State != ConnectionState.Open)
            {
                commandDetail.Connection.Open();
            }
            commandDetail.Parameters.AddWithValue("@p1", id);
            SqlDataReader sqlDataStudent = commandDetail.ExecuteReader();
            
                EntityStudent studentDetail = new EntityStudent();
            while (sqlDataStudent.Read())
            {
                studentDetail.Name = sqlDataStudent["STDNAME"].ToString();
                studentDetail.Surname = sqlDataStudent["STDSURNAME"].ToString();
                studentDetail.Number = sqlDataStudent["STDNUMBER"].ToString();
                studentDetail.Password = sqlDataStudent["STDPASSWORD"].ToString();
                studentDetail.Image = sqlDataStudent["STDIMAGE"].ToString();
                studentDetail.Balance = Convert.ToDouble(sqlDataStudent["STDBALANCE"].ToString());
            }
           
            sqlDataStudent.Close();
            return studentDetail;
        }
        public static bool studentDelete(int delId)
        {
            if (deneme(delId) == true)
                return false;

            SqlCommand DeleteStudent = new SqlCommand("Delete From Student_Table Where STDID=@p1",Connection.con);
            if (DeleteStudent.Connection.State != ConnectionState.Open)
            {
                DeleteStudent.Connection.Open();
            }
            

            DeleteStudent.Parameters.AddWithValue("@p1", delId);
            return DeleteStudent.ExecuteNonQuery()>0 ;
        }
        static bool deneme(int a)
        {
            SqlCommand recourseFormRequest = new SqlCommand("select * From RECOURSEFORM_TABLE Where STDID=@p2", Connection.con);
            if (recourseFormRequest.Connection.State != ConnectionState.Open)
            {
                recourseFormRequest.Connection.Open();
            }

            recourseFormRequest.Parameters.AddWithValue("@p2", a);
            SqlDataReader sqlDataStudent = recourseFormRequest.ExecuteReader();
            if (sqlDataStudent.HasRows)
            {
                sqlDataStudent.Close();
                return true;
            }
            sqlDataStudent.Close();
            return false;
        }
        public static bool studentUpdate(EntityStudent student)
        {
            SqlCommand command = new SqlCommand("Update Student_Table Set StdName=@p1,StdSurname=@p2," +
                "StdNumber=@p3,StdImage=@p4,StdPassword=@p5 Where StdId=@p6", Connection.con);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@p6", student.Id);
            command.Parameters.AddWithValue("@p1", student.Name);
            command.Parameters.AddWithValue("@p2", student.Surname);
            command.Parameters.AddWithValue("@p3", student.Number);
            command.Parameters.AddWithValue("@p4", student.Image);
            command.Parameters.AddWithValue("@p5", student.Password);


            return command.ExecuteNonQuery() > 0 ;//etkilenen kayıt sayısı geri döndürülür
        }
    }
}
