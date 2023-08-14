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
    public partial class DeleteStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(Request.QueryString["ogrId"]);
            Response.Write(id);
            //EntityStudent studentDel = new EntityStudent();
            //studentDel.Id = id;
            BLLStudent.studentDeleteBLL(id);
            Response.Redirect("StudentList.aspx");
        }
    }
}