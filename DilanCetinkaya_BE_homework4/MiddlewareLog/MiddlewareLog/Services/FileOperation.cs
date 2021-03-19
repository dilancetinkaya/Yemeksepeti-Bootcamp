using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareLog.Services
{
    public class FileOperation
    {

        private readonly string _filePathRequest = @"Logs/RequestLogs.json";
        private readonly string _filePathResponse = @"Logs/ResponseLogs.json";
        public List<RequestDto> ReadRequest()
        {
            return JsonConvert.DeserializeObject<List<RequestDto>>(File.ReadAllText(_filePathRequest));
        }
        public List<ResponseDto> ReadResponse()
        {
            return JsonConvert.DeserializeObject<List<ResponseDto>>(File.ReadAllText(_filePathResponse));
        }
        public void WriteRequest(List<RequestDto> model)
        {
            File.WriteAllText(_filePathRequest, JsonConvert.SerializeObject(model));
        }
        public void WriteResponse(List<ResponseDto> model)
        {
            File.WriteAllText(_filePathResponse, JsonConvert.SerializeObject(model));
        }
    }
}

