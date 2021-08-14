using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class CS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            this.BindGrid();
        }
    }

    private void BindGrid()
    {
        CRUD_Service.ServiceCS service = new CRUD_Service.ServiceCS();
        GridView1.DataSource = service.Get();
        GridView1.DataBind();
    }
}