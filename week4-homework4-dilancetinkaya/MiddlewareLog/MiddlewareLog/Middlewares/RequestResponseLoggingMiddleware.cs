using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using MiddlewareLog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace MiddlewareLog.Middlewares
{
    public class RequestResponseLoggingMiddleware
    {
       

            private readonly RequestDelegate _requestDelegate;
            private readonly ILogger _logger;
            Guid _id;
            private FileOperation _fileService;
            public RequestResponseLoggingMiddleware(RequestDelegate requestDelegate, ILoggerFactory loggerFactory)
            {
                _requestDelegate = requestDelegate;
                _logger = loggerFactory.CreateLogger<RequestResponseLoggingMiddleware>();
                _fileService = new FileOperation();
            }


            public async Task Invoke(HttpContext context)
            {
                _id = Guid.NewGuid();
                var request = context.Request;
                RequestMiddleware(request);
                await _requestDelegate(context);

                var response = context.Response;
                ResponseMiddleware(response);
            }

            public void RequestMiddleware(HttpRequest request)
            {
                List<RequestDto> mylogs = _fileService.ReadRequest();
                RequestDto requestLog = new RequestDto
                {
                    Id = _id,
                    Host = request.Host.Value,
                    CreatedTime = DateTime.Now,
                    Method = request.Method,
                    Path = request.Path
                };

                mylogs.Add(requestLog);

                _fileService.WriteRequest(mylogs);
            }

            public void ResponseMiddleware(HttpResponse response)
            {
                List<ResponseDto> mylogs = _fileService.ReadResponse();

                ResponseDto responseLog = new ResponseDto
                {
                    Id = _id,
                    StatusCode = response.StatusCode,
                    CreatedTime = DateTime.Now
                };
                mylogs.Add(responseLog);

                _fileService.WriteResponse(mylogs);

            }

        }
    }
