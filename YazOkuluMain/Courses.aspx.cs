using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer.Concrete;
using DataAccesLayer;
using BusinessLogicLayer;
using System.Data.SqlClient;
using System.Data;
public partial class Courses : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityCourse> EntCourse = BLLCourse.BLLCourseList();
        DropDownList1.DataSource = BLLCourse.BLLCourseList();
        DropDownList1.DataTextField = "CourseName";
        DropDownList1.DataValueField = "Id";
        DropDownList1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityApplicationForm form = new EntityApplicationForm();
        form.Id = int.Parse(TextBox1.Text);
        form.ApplicationStudentId = int.Parse(DropDownList1.SelectedValue.ToString());
        BLLCourse.AddRequestBLL(form);
    }
}