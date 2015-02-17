using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PBM.Web.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            using (ServicioWCF.ServicioUsuarioClient cli = new ServicioWCF.ServicioUsuarioClient())
            {
                List<BPM_SAS.Entidades.Usuario> users = cli.ObtenerUsuarios();

                return View(users);
            }
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            using (ServicioWCF.ServicioUsuarioClient cli = new ServicioWCF.ServicioUsuarioClient())
            {
                BPM_SAS.Entidades.Usuario user = cli.ObtenerUsuario(id);

                return View(user);
            }
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                using (ServicioWCF.ServicioUsuarioClient cli = new ServicioWCF.ServicioUsuarioClient())
                {
                    bool bln = false;
                    BPM_SAS.Entidades.Usuario usr = new BPM_SAS.Entidades.Usuario();
                    usr.Apellidos = collection["Apellidos"];
                    usr.Correo = collection["Correo"];
                    bool.TryParse(collection["Estado"], out bln);
                    usr.Estado = bln;
                    usr.Nombres = collection["Nombres"];
                    usr.Telefono = long.Parse(collection["Telefono"]); 

                    bool result = cli.Insert(usr);

                    if (result == true)
                        return RedirectToAction("Index");
                    else
                        return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            using (ServicioWCF.ServicioUsuarioClient cli = new ServicioWCF.ServicioUsuarioClient())
            {
                BPM_SAS.Entidades.Usuario user = cli.ObtenerUsuario(id);

                return View(user);
            }
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                using (ServicioWCF.ServicioUsuarioClient cli = new ServicioWCF.ServicioUsuarioClient())
                {
                    bool bln = false;
                    BPM_SAS.Entidades.Usuario usr = new BPM_SAS.Entidades.Usuario();
                    usr.Apellidos = collection["Apellidos"];
                    usr.Correo = collection["Correo"];
                    bool.TryParse(collection["Estado"], out bln);
                    usr.Estado = bln;
                    usr.Nombres = collection["Nombres"];
                    usr.Telefono = long.Parse(collection["Telefono"]);
                    usr.UsuarioID = int.Parse(collection["UsuarioID"]);

                    bool result = cli.Update(usr);

                    if (result == true)
                        return RedirectToAction("Index");
                    else
                        return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            using (ServicioWCF.ServicioUsuarioClient cli = new ServicioWCF.ServicioUsuarioClient())
            {
                BPM_SAS.Entidades.Usuario user = cli.ObtenerUsuario(id);


                return View(user);
            }
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (ServicioWCF.ServicioUsuarioClient cli = new ServicioWCF.ServicioUsuarioClient())
                {
                                 
                    bool result = cli.Delete(id);

                    if (result == true)
                        return RedirectToAction("Index");
                    else
                        return View();
                }


            }
            catch
            {
                return View();
            }
        }
    }
}
