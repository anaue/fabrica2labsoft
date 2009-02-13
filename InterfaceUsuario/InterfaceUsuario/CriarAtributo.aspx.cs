using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace InterfaceUsuario
{
    public partial class CriarAtributo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue.Equals("Lista"))
            {
                Label2.Visible = true;
                DropDownList2.Visible = true;
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (textBox_nome.Text.Trim().Equals(""))
            {
                lb_nome.Visible = true; 
            }
            else { 
            
            
            }

        }


    }
}
