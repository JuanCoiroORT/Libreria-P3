using Compartido.DTOs;
using LogicaAplicacion.ImplementacionCasosUso.RevistaCU;
using LogicaNegocio.EntidadesNegocio;
using LogicaNegocio.ExcepcionesEntidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models.Revistas;

namespace MVC.Controllers
{
    public class RevistaController : Controller
    {
        private AltaRevista CUAltaRevista = new AltaRevista();
        private ListadoRevista CUListadoRevista = new ListadoRevista();
        // GET: RevistaController
        public ActionResult Index()
        {
            List<ListadoRevistaDTO> revistasDTO = CUListadoRevista.Ejecutar();
            IEnumerable<ListadoRevistaViewModel> listadoRevistaViewModels = new List<ListadoRevistaViewModel>();
            /*foreach(ListadoRevistaDTO revistaDTO in revistasDTO)
            {
                listadoRevistaViewModels.Add(new ListadoRevistaViewModel()
                {
                    Id = revistaDTO.Id,
                    Nombre = revistaDTO.Nombre
                });
            }*/
            // MISMO RESULTADO QUE EN EL FOREACH
            try
            {
                listadoRevistaViewModels = revistasDTO.Select(c => new ListadoRevistaViewModel()
                {
                    Id = c.Id,
                    Nombre = c.Nombre
                }).ToList();
            }
            catch(Exception ex)
            {
                ViewBag.Message = "Datos incorrectos.";
            }
           
            return View(listadoRevistaViewModels);
        }

        // GET: RevistaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RevistaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RevistaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RevistaViewModel revistaVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RevistaDTO revistaDTO = new RevistaDTO()
                    {
                        Tema = revistaVM.Tema,
                        PrecioSugerido = revistaVM.PrecioSugerido,
                        Editorial = revistaVM.Editorial,
                        CantPaginas = revistaVM.CantPaginas,
                        FechaPublicacion = revistaVM.FechaPublicacion,
                        ImagenPortada = revistaVM.ImagenPortada,
                        Stock = revistaVM.Stock,
                        StockMinimo = revistaVM.StockMinimo,
                        Autores = revistaVM.Autores,
                        Valoraciones = revistaVM.Valoraciones,
                        Nombre = revistaVM.Nombre,
                        Numero = revistaVM.Numero,
                        Anio = revistaVM.Anio,
                        Contenido = revistaVM.Contenido
                    };
                    CUAltaRevista.Ejecutar(revistaDTO);
                    ViewBag.Message = "Revista creada correctamente.";
                    return View();
                }
            }
            catch (RevistaException ex)
            {
                ViewBag.Message = ex.Message;
            }
            catch(Exception ex)
            {
                ViewBag.Message = "Datos incorrectos.";
            }
            return View();
        }
          
                
            

        // GET: RevistaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RevistaController/Edit/5
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

        // GET: RevistaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RevistaController/Delete/5
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
