using InjectionLifeCycle.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjectionLifeCycle.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LifeController : ControllerBase
    {

        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;
        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;


        public LifeController(ITransientService transientService1,
                                         ITransientService transientService2,
                                         IScopedService scopedService1,
                                         IScopedService scopedService2,
                                         ISingletonService singletonService1,
                                         ISingletonService singletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }







        [HttpGet]
        public string Get()
        {
            string result = $"Transient result1 : {_transientService1.GetId()}{Environment.NewLine}" +
                                                    
                            $"Transient result2 : {_transientService2.GetId()} {Environment.NewLine}" +
                            $"Scoped result1 : {_scopedService1.GetId() } {Environment.NewLine}" +
                            $"Scoped2 result2 : {_scopedService2.GetId()} {Environment.NewLine}" +
                            $"Singleton result1 : {_singletonService1.GetId() } {Environment.NewLine}" +
                            $"Singleton result2 : {_singletonService2.GetId()} {Environment.NewLine}";

            return result;



        }
    }
}
