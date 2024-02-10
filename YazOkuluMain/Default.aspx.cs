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
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        EntityStudent entityStudent = new EntityStudent();
        entityStudent.Name = TxtAd.Text;
        entityStudent.SurName = TxtSoyad.Text;
        entityStudent.Number = TxtNumara.Text;
        entityStudent.Password = TxtSifre.Text;
        entityStudent.Image = TxtFoto.Text;
        BLLStudent.AddStudentBLL(entityStudent);
    }
}