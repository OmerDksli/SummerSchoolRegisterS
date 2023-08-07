using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayers;
using BusinessLogicLayer;
namespace SummerSchoolRegisterS
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityStudent student = new EntityStudent();
            student.Name = TxtName.Text;
            student.Surname = TxtSurname.Text;
            student.Number = TxtNumber.Text;
            student.Image = TxtImage.Text;
            student.Password =TxtPasword.Text;
            BLLStudent.AddStudentBLL(student);
        }
    }
}