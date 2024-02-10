using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer.Concrete;
using DataAccesLayer;
using BusinessLogicLayer;
public partial class UpdateStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["STDID"].ToString());
        TxtId.Text= x.ToString();
        TxtId.Enabled = false;
        if (Page.IsPostBack == false)
        {
            EntityStudent student = new EntityStudent();
            List<EntityStudent> students = BLLStudent.BllDetail(x);
            TxtAd.Text = students[0].Name.ToString();
            TxtSoyad.Text = students[0].SurName.ToString();
            TxtNumara.Text = students[0].Number.ToString();
            TxtFoto.Text = students[0].Image.ToString();
            TxtSifre.Text = students[0].Password.ToString();
        }
      
    }

    
    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityStudent student = new EntityStudent();    
        student.Name = TxtAd.Text;
        student.SurName = TxtSoyad.Text;
        student.Number = TxtNumara.Text;
        student.Image = TxtFoto.Text;
        student.Password = TxtSifre.Text;
        student.Id = Convert.ToInt32(TxtId.Text);
        BLLStudent.UpdateStudentBLL(student);
        Response.Redirect("Student_List.aspx");
    }
}