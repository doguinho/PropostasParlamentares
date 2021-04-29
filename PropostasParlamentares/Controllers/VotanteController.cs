using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropostasParlamentares.Models;

namespace PropostasParlamentares.Controllers
{
    [ApiController]
    [Route("/votante")]
    public class VotanteController : Controller
    {
        private List<Votante> lista = new List<Votante>();

        public VotanteController()
        {
            Votante votante = new Votante();
            votante.id = 1;
            this.lista.Add(votante);
        }

        // GET: VotateController
        [HttpGet]
        [Route("listar")]
        public IList<Votante> List()
        {

            return this.lista;
        }

        // GET: VotateController/Details/5
        [HttpGet]
        [Route("detalhes/{id}")]
        public IList<Votante> Details(int id)
        {
            return lista.Where(
                v => v.id == id).ToList();
        }

        // POST: VotateController/Create
        [HttpPost]
        [Route("adicionar")]
        public String Create([FromBody] Votante votante)
        {
            if (lista.Where(v => v.id == votante.id).Count() > 0)
            {
                return "Já existe um votante com esse id";
            } else
            {
                this.lista.Add(votante);
                return "Votante adicionado com sucesso";
            }
        }

        // GET: VotateController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VotateController/Edit/5
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

        // GET: VotateController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VotateController/Delete/5
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
