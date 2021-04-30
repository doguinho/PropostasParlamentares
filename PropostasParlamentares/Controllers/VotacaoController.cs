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
    [Route("/votacao")]
    public class VotacaoController : Controller
    {
        private readonly DataBaseContext ctx;
        public VotacaoController()
        {
            ctx = new DataBaseContext();
        }

        [HttpGet]
        [Route("listar")]
        public IList<Votacao> List()
        {
            return ctx.Votacao.ToList<Votacao>();
        }

        [HttpGet]
        [Route("detalhes/{id}")]
        public IList<Votacao> Details(int id)
        {
            return ctx.Votacao.ToList<Votacao>().Where(v => v.id == id).ToList();
        }

        [HttpPost]
        [Route("inserir")]
        public void Create([FromBody] Votacao v)
        {
            ctx.Votacao.Add(v);
            ctx.SaveChanges();
        }

        [HttpPut]
        [Route("editar")]
        public void Edit([FromBody] Votacao v)
        {
            ctx.Votacao.Update(v);
            ctx.SaveChanges();
        }

        [HttpDelete]
        [Route("apagar/{id}")]
        public void Delete(int id)
        {
            Votacao v = new Votacao();
            v.id = id;
            ctx.Votacao.Remove(v);
            ctx.SaveChanges();
        }

    }
}
