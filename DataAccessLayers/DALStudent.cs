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
            return entityStudentsList;
        }
    }
}
