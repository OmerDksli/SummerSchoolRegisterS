using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayers;
namespace SummerSchoolRegisterS
{
    public partial class Lesson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityLesson> lessons = BLLLesson.BllLessonList();
            DropDownList1.DataSource = lessons;
            DropDownList1.DataTextField = "LessonName";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
        }
    }
}