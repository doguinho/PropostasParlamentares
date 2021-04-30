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
    [Route("/voto")]
    public class VotoController : Controller
    {
        private readonly DataBaseContext ctx;

        public VotoController()
        {
            ctx = new DataBaseContext();
        }

        [HttpGet]
        [Route("listar")]
        public IList<Voto> List()
        {
            return ctx.Voto.ToList<Voto>();
        }

        [HttpGet]
        [Route("detalhes/{id}")]
        public IList<Voto> Details(int id)
        {
            return ctx.Voto.ToList<Voto>().Where(v => v.id == id).ToList();
        }

        [HttpPost]
        [Route("inserir")]
        public void Create([FromBody] Voto voto)
        {
            ctx.Voto.Add(voto);
            ctx.SaveChanges();
        }

        [HttpPut]
        [Route("editar")]
        public void Edit([FromBody] Voto voto)
        {
            ctx.Voto.Update(voto);
            ctx.SaveChanges();
        }

        [HttpDelete]
        [Route("apagar/{id}")]
        public void Delete(int id)
        {
            Voto voto = new Voto();
            voto.id = id;
            ctx.Voto.Remove(voto);
            ctx.SaveChanges();
        }

    }
}
