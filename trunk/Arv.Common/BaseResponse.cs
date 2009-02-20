using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Arv.Common
{
    public class BaseResponse
    {
        public enum ResponseStatus
        {
            None = 0,
            Continue = 100,
            OK = 200,
            Created = 201,
            Accepted = 202,
            NoContent = 204,
            MovedPermanently = 301,
            Found = 302,
            SeeOther = 303,
            NotModified = 304,
            BadRequest = 400,
            Unauthorized = 401,
            Forbidden = 403,
            NotFound = 404,
            MethodNotAllowed = 405,
            RequestTimeout = 408,
            Conflict = 409,
            NotImplemented = 501,
            ServiceUnavailable = 503,
            BadVersion = 505,
            InternalServerError = 500
        }

        private ResponseStatus _statusCode;

        [XmlElement(ElementName = "StatusCode")]
        public ResponseStatus StatusCode
        {
            get { return _statusCode; }
            set { _statusCode = value; }
        }
    }
}
