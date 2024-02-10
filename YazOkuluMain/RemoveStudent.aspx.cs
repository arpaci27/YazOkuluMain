using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer.Concrete;
public partial class RemoveStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["STDID"]);
        Response.Write(x);
        EntityStudent student = new EntityStudent();
        student.Id = x;
        BLLStudent.RemoveStudent(student.Id);
        Response.Redirect("Student_List.aspx");
    }
}