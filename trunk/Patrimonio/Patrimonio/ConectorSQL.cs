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
            StringConexao = "Data Source=(windowsxpvm\\sqlexpress);Initial Catalog=fabrica2db;User ID=fabrica2db;Password=fabrica2db";
            
        }
    }
}
