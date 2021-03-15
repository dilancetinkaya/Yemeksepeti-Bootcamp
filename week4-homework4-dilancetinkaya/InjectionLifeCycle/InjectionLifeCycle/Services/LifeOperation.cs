using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjectionLifeCycle.Services
{
    public class LifeOperation : ISingletonService, ITransientService, IScopedService
    {

        Guid _id;
        DateTime _time;
     
       


        public LifeOperation()
        {
            _id = Guid.NewGuid();
         


        }

        public DateTime GetDate()
        {
            return _time;
        }

        public Guid GetId()
        {
            return _id;
        }

    }
    public interface ISingletonService
    {
        Guid GetId();
        DateTime GetDate();
   

    }

    public interface IScopedService
    {
        Guid GetId();
        DateTime GetDate();


    }

    public interface ITransientService
    {
        Guid GetId();
        DateTime GetDate();


    }

}



