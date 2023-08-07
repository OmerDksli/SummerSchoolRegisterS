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
    }
}
