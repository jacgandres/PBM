using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using BPM_SAS.DAL;
using BPM_SAS.Entidades;

namespace BPM_SAS.Servicio
{
    [AspNetCompatibilityRequirements(RequirementsMode
      = AspNetCompatibilityRequirementsMode.Allowed)]
    public class UsuarioAjaxWCF : IUsuarioAjaxWCF
    {
        public bool Insert(Usuario pUser)
        {
            using (BPM_SASContext context = new BPM_SASContext())
            {
                context.Usuario.Add(pUser);

                return context.SaveChanges() > 0;
            }
        }
    }
}
