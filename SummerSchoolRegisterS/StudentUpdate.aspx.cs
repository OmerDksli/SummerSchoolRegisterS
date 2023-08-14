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
    public partial class StudentUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var id = Convert.ToInt32(this.ClientQueryString);
            var id = Convert.ToInt32(Request.QueryString["ogrId"]);
            TxtId.Text = id.ToString();
            TxtId.Enabled = false;
            if (Page.IsPostBack == false) { 
            var editStudent=BLLStudent.BllStudentDetail(id);
            TxtName.Text = editStudent.Name;
            TxtSurname.Text = editStudent.Surname;
            TxtNumber.Text = editStudent.Number;
            TxtPasword.Text = editStudent.Password;
            TxtImage.Text = editStudent.Image;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            EntityStudent student = new EntityStudent();
            student.Id= Convert.ToInt32(TxtId.Text);
            student.Name = TxtName.Text;
            student.Surname = TxtSurname.Text;
            student.Number = TxtNumber.Text;
            student.Image = TxtImage.Text;
            student.Password = TxtPasword.Text;

            BLLStudent.studentUpdateBLL(student);
            
        }
    }
}