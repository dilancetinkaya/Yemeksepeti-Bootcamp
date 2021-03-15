using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareLog.Services
{
    public class ResponseDto
    {
        public Guid Id { get; set; }
        public int StatusCode { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
