using Microsoft.AspNetCore.Mvc;

using CRUDfictisiaLuciano.Datos;
using CRUDfictisiaLuciano.Models;

namespace CRUDfictisiaLuciano.Controllers
{
    public class MantenedorController : Controller
    {
        SEGURODATOSdatos _SEGURODATOSdatos = new SEGURODATOSdatos();

        public IActionResult Listar()
        {
            //Las vista mostrara una lista de contactos 
            var oLista = _SEGURODATOSdatos.Listar();

            return View(oLista);
        }
        public IActionResult Guardar()
        {
            //Metodo solo devuelve la vista
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(DATOSSEGUROmodel oContacto)
        {
            //Metodo recibe un objeto para guardarlo en bd
            if (!ModelState.IsValid)
                return View();

            var respuesta = _SEGURODATOSdatos.Guardar(oContacto);
            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
        public IActionResult Editar(int identificacion)
        {

            var ocontacto = _SEGURODATOSdatos.Obtener(identificacion);
            return View(ocontacto);
        }
        [HttpPost]
        public IActionResult Editar(DATOSSEGUROmodel oContacto)
        {

            if (!ModelState.IsValid)
                return View();

            var respuesta = _SEGURODATOSdatos.Editar(oContacto);
            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Eliminar(int identificacion)
        {

            var ocontacto = _SEGURODATOSdatos.Obtener(identificacion);
            return View();
        }
        [HttpPost]
        public IActionResult Eliminar(DATOSSEGUROmodel oContacto)
        {

            var respuesta = _SEGURODATOSdatos.Eliminar(oContacto.identificacion);
            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }


    }
}
