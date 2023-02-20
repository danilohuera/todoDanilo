using System;
using System.Collections.Generic;
using System.Text;

namespace todoDanilo.Common.Responses
{
    class Response
    {
        public bool IsSuccess { get; set; }
        public string Nessage { get; set; }
        public object Result { get; set; }
    }
}
