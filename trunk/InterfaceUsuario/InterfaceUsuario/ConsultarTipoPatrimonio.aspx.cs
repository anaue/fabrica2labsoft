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
using InterfaceUsuario.Classes;
using System.Collections.Generic;

namespace InterfaceUsuario
{
    public partial class ConsultarTipoPatrimonio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void cboNomeTipoPatrimonio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNomeTipoPatrimonio.SelectedIndex != 0)
            {
                try
                {
                    Classes.TipoPatrimonio tipoPatrimonio = new InterfaceUsuario.Classes.TipoPatrimonio();
                    tipoPatrimonio = tipoPatrimonio.ConsultaTipoPatrimonio(cboNomeTipoPatrimonio.SelectedIndex);
                    txtNome.Text = tipoPatrimonio.Nome;
                    txtDescricao.Text = tipoPatrimonio.Descricao;
                    //Popula lista dos Atributos do tipo selecionado
                    lstAtributosDoTipo.DataSource = tipoPatrimonio.ListAtributos;
                    lstAtributosDoTipo.DataValueField = "Id";
                    lstAtributosDoTipo.DataTextField = "Nome";
                    lstAtributosDoTipo.DataBind();
                    //Popula lista dos Atributos de todos os atributos disponiveis
                    lstAtributosDisponiveis.DataSource = InterfaceUsuario.Classes.TipoPatrimonio.ListaAtributosDisponiveis();
                    lstAtributosDisponiveis.DataValueField = "Id";
                    lstAtributosDisponiveis.DataTextField = "Nome";
                    // deleta todos os itens que estão sendo mostrados no atributos do tipo
                    foreach (ListItem item in lstAtributosDoTipo.Items)
                    {
                        lstAtributosDisponiveis.Items.Remove(item.Text);
                    }

                }
                catch (Exception ex)
                {
 
                }
 
            }
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Classes.TipoPatrimonio tipoPatrimonio = new InterfaceUsuario.Classes.TipoPatrimonio();
            tipoPatrimonio.Nome = txtNome.Text;
            tipoPatrimonio.Descricao = txtDescricao.Text;
            tipoPatrimonio.Id = cboNomeTipoPatrimonio.SelectedIndex;
            List<Atributo> listaAtributos = new List<Atributo>();

            foreach (ListItem item in lstAtributosDoTipo.Items)
            {
                tipoPatrimonio.ListAtributos.Add(new Atributo(Convert.ToInt32(item.Value)));
            }
             tipoPatrimonio.AlteraTipoPatrimonio(tipoPatrimonio);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        protected void btnRemoverAtributos_Click(object sender, EventArgs e)
        {
            if (lstAtributosDoTipo.SelectedIndex != -1)
            {
                lstAtributosDisponiveis.Items.Add(new ListItem(lstAtributosDoTipo.SelectedItem.Text, lstAtributosDoTipo.SelectedValue));
                lstAtributosDisponiveis.DataValueField = "Id";
                lstAtributosDisponiveis.DataTextField = "Nome";
                lstAtributosDoTipo.Items.RemoveAt(lstAtributosDoTipo.SelectedIndex);
                lstAtributosDoTipo.DataBind();
            }
        }

        protected void btnAdicionarAtributos_Click(object sender, EventArgs e)
        {
            if (lstAtributosDisponiveis.SelectedIndex != -1)
            {
                lstAtributosDoTipo.Items.Add(new ListItem(lstAtributosDisponiveis.SelectedItem.Text, lstAtributosDisponiveis.SelectedValue));
                lstAtributosDoTipo.DataValueField = "Id";
                lstAtributosDoTipo.DataTextField = "Nome";
                lstAtributosDisponiveis.Items.RemoveAt(lstAtributosDisponiveis.SelectedIndex);
                lstAtributosDisponiveis.DataBind();
            }

        }

 
    }
}
