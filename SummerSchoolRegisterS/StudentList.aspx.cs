using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer;
using DataAccessLayers;

namespace SummerSchoolRegisterS
{
    public partial class StudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<EntityStudent> AllStudents = BLLStudent.BllStudentList();
            Repeater1.DataSource = AllStudents;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender)
        {

        }
    }
}