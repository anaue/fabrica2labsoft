using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Patrimonio
{
    
    public class ConectorSQL
    {
        public String StringConexao;
    //Construtor
    public  ConectorSQL()
        {
            StringConexao = "Data Source=WINDOSXPVM\\SQLEXPRESS;Initial Catalog=fabrica2db_local;Integrated Security=True";
            
        }
    }
}
