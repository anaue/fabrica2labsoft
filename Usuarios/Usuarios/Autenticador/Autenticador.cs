using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Usuarios.Autenticador
{
    [XmlRoot(ElementName = "Autenticador")]
    public class Autenticador
    {
        public Autenticador()
        {
        }
        private int _idUsuario;
        [XmlElement(ElementName = "IdUsuario")]
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        private bool _permissaoIncluir;
        [XmlElement(ElementName = "PermissaoIncluir")]
        public bool PermissaoIncluir
        {
            get { return _permissaoIncluir; }
            set { _permissaoIncluir = value; }
        }
        private bool _permissaoExcluir;
        [XmlElement(ElementName = "PermissaoExcluir")]
        public bool PermissaoExcluir
        {
            get { return _permissaoExcluir; }
            set { _permissaoExcluir = value; }
        }
        private bool _permissaoConsultar;
        [XmlElement(ElementName = "PermissaoConsultar")]
        public bool PermissaoConsultar
        {
            get { return _permissaoConsultar; }
            set { _permissaoConsultar = value; }
        }
        private bool _permissaoEditar;
        [XmlElement(ElementName = "PermissaoEditar")]
        public bool PermissaoEditar
        {
            get { return _permissaoEditar; }
            set { _permissaoEditar = value; }
        }

    }
}
