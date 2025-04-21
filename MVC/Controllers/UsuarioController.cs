using Compartido.DTOs;
using LogicaAplicacion.ImplementacionCasosUso.UsuarioCU;
using LogicaNegocio.ExcepcionesEntidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models.Usuarios;

namespace MVC.Controllers
{
    public class UsuarioController : Controller
    {
        private AltaUsuario CUAltaUsuario = new AltaUsuario();

        // GET: UsuarioController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel usuarioVM)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    UsuarioDTO usuarioDTO = new UsuarioDTO()
                    {
                        NombreUsuario = usuarioVM.NombreUsuario,
                        Password = usuarioVM.Password,
                        Rol = usuarioVM.Rol
                    };
                    CUAltaUsuario.Ejecutar(usuarioDTO);
                    ViewBag.Message = "Usuario creado correctamente.";
                    return View();
                }
            }
            catch(UsuarioException ex) 
            {
                ViewBag.Message = ex.Message;
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error en los datos.";
            }
            return View();
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
