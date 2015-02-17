using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BPM_SAS.Entidades;

namespace BPM_SAS.Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUsuarioAjaxWCF" in both code and config file together.
    [ServiceContract]
    public interface IUsuarioAjaxWCF
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Wrapped,
                UriTemplate = "/Insert")]
        bool Insert(Usuario pUser);
    }
}
