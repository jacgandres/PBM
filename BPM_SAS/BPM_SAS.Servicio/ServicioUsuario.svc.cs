using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BPM_SAS.DAL;
using BPM_SAS.Entidades;

namespace BPM_SAS.Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioUsuario" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioUsuario.svc or ServicioUsuario.svc.cs at the Solution Explorer and start debugging.
    public class ServicioUsuario : IServicioUsuario
    { 
        public Usuario ObtenerUsuario(int pID)
        {
            using (BPM_SASContext cont = new BPM_SASContext())
            {
                var usuario = from usrs in cont.Usuario
                              where usrs.UsuarioID == pID
                              select usrs;

                var result = usuario.SingleOrDefault();

                return result;
            }
             
        }

        public List<Usuario> ObtenerUsuarios()
        {
            using (BPM_SASContext cont = new BPM_SASContext())
            {
                var usrs = from usr in cont.Usuario
                           select usr;

                return usrs.ToList<Usuario>();
            }
        }

        public List<Usuario> List()
        {
            using (BPM_SASContext cont = new BPM_SASContext())
            {
                var usrs = from usr in cont.Usuario
                           select usr;

                return usrs.ToList<Usuario>();
            }
        }

        public bool Insert(Usuario pUser)
        {
            using(BPM_SASContext context = new BPM_SASContext())
            {
                context.Usuario.Add(pUser);

                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(int pID)
        {
            using (BPM_SASContext context = new BPM_SASContext())
            {
                Usuario usuario = context.Usuario.Find(pID);
                if (usuario != null)
                {
                    context.Usuario.Remove(usuario);
                    return context.SaveChanges() > 0;
                }
                else
                    throw new ApplicationException("El id del usuario solicitado no fue encontrado");
            }
        }

        public bool Update(Usuario pUser)
        {
            using (BPM_SASContext context = new BPM_SASContext())
            {
                context.Entry(pUser).State = System.Data.Entity.EntityState.Modified;

                return context.SaveChanges() > 0;
            }
        }
    }
}
