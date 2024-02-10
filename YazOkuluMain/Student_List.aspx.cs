using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer.Concrete;
using DataAccesLayer;
using BusinessLogicLayer;
public partial class Student_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityStudent> StdList= BLLStudent.BllList();
        Repeater1.DataSource = StdList;
        Repeater1.DataBind();
    }
}