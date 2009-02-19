﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Patrimonio.Relatorio
{
    [XmlRoot(ElementName = "ResponseRelatorio")]
    public class ResponseRelatorio
    {
        public ResponseRelatorio()
        {
        }
        private int _statusCode;
        [XmlElement(ElementName = "StatusCode")]
        public int StatusCode
        {
            get { return _statusCode; }
            set { _statusCode = value; }
        }

        private string _Message;
        [XmlElement(ElementName = "Message", IsNullable = true)]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
    }
}