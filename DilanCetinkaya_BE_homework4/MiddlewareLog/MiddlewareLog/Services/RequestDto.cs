using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareLog.Services
{
    public class RequestDto
    {
        public Guid Id { get; set; }
        public string Method { get; set; }
        public string Host { get; set; }
        public PathString Path { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
