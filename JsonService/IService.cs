using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace JsonService
{

    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        void DoWork();

        
        [OperationContract]
        [WebInvoke(Method ="POST",ResponseFormat =WebMessageFormat.Json,
            BodyStyle =WebMessageBodyStyle.Wrapped,UriTemplate ="json/sayhi")]
        string SayHi(string name);

    }
    
}