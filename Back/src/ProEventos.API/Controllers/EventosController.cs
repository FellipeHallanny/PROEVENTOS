using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Domain;
using ProEventos.Persistence.Contextos;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {           
        private readonly ProEventosContext context;

        public EventosController(ProEventosContext context) => this.context = context;

        [HttpGet]
        public IEnumerable<Evento> Get() => this.context.Eventos;

        [HttpGet("{id}")]
        public Evento GetById(int id) => this.context.Eventos.FirstOrDefault(evento => evento.Id == id);
    }
}
