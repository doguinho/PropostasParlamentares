using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropostasParlamentares.Models;
using PropostasParlamentares.Context;

namespace PropostasParlamentares.Controllers
{
    [ApiController]
    [Route("/votante")]
    public class VotanteController : Controller
    {
        private readonly DataBaseContext ctx;

        public VotanteController()
        {
            ctx = new DataBaseContext();
        }

        // GET: VotateController
        [HttpGet]
        [Route("listar")]
        public IList<Votante> List()
        {
            return ctx.Votante.ToList<Votante>();
        }

        // GET: VotateController/Details/5
        [HttpGet]
        [Route("detalhes/{id}")]
        public IList<Votante> Details(int id)
        {
            return ctx.Votante.ToList<Votante>().Where(v => v.id == id).ToList();
        }

        // POST: VotateController/Create
        [HttpPost]
        [Route("inserir")]
        public void Create([FromBody] Votante votante)
        {
            ctx.Votante.Add(votante);
            ctx.SaveChanges();
        }

        // GET: VotateController/Edit/5
        [HttpPut]
        [Route("editar")]
        public void Edit([FromBody] Votante votante)
        {
            ctx.Votante.Update(votante);
            ctx.SaveChanges();
        }

        [HttpDelete]
        [Route("apagar/{id}")]
        public void Delete(int id)
        {
            Votante votante = new Votante();
            votante.id = id;
            ctx.Votante.Remove(votante);
            ctx.SaveChanges();
        }
    }
}
