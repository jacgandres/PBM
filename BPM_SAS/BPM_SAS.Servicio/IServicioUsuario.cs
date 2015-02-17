using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BPM_SAS.Entidades;

namespace BPM_SAS.Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioUsuario" in both code and config file together.
    [ServiceContract]
    public interface IServicioUsuario
    {  
        [OperationContract]
        BPM_SAS.Entidades.Usuario ObtenerUsuario(int pID);


        [OperationContract]
        List<BPM_SAS.Entidades.Usuario> List();

        [OperationContract]
        List<BPM_SAS.Entidades.Usuario> ObtenerUsuarios();

        [OperationContract]
        bool Insert(Usuario pUser);

        [OperationContract]
        bool Delete(int pID);

        [OperationContract]
        bool Update(Usuario pUser);

    }
}
