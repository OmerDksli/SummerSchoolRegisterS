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
            if (Page.IsPostBack==false)
            {   
            List<EntityLesson> lessons = BLLLesson.BllLessonList();
            DropDownList1.DataSource = lessons;
            DropDownList1.DataTextField = "LessonName";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityRecourseForm entityRecourse = new EntityRecourseForm();
            entityRecourse.LessonId = int.Parse(DropDownList1.SelectedValue.ToString());
            entityRecourse.StdId = int.Parse(TextBox1.Text);
            BLLLesson.BllLessonRequest(entityRecourse); 
        }
    }
}