using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace InterfaceUsuario.Classes
{
    public class Usuario
    {

        public Usuario()
        {
        }
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        private int _tipoUsuario;
        public int TipoUsuario
        {
            get { return _tipoUsuario; }
            set { _tipoUsuario = value; }
        }

        public int CriaUsuario(Usuario usuario)
        {
            InterfaceUsuario.WS.Usuario user = new InterfaceUsuario.WS.Usuario();
            return user.CriarUsuario(usuario);
        }

        public bool DeletaAtributo(int id) {
            InterfaceUsuario.WS.Usuario user = new InterfaceUsuario.WS.Usuario();
            return user.DeletaUsuario(id);
        }

        public bool AlteraUsuario(Usuario usuario) {
            InterfaceUsuario.WS.Usuario user = new InterfaceUsuario.WS.Usuario();
            return user.AlteraUsuario(usuario);
        }

        public Classes.Usuario ConsultaUsuario(int id)
        {
            InterfaceUsuario.WS.Usuario user = new InterfaceUsuario.WS.Usuario();
            return user.ConsultaUsuario(id);
        }

        public List<Classes.Usuario> BuscaUsuarios(String nome, String descricao)
        {
            InterfaceUsuario.WS.Usuario user = new InterfaceUsuario.WS.Usuario();
            return user.BuscaUsuarios(nome,descricao);
        }

    }
}
