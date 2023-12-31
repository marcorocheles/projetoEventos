﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento(){
                EventoId = 1,
                Tema ="Angular 11 e .NET Core",
                Local = "Belo Horizonte",
                Lote = "1 Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "img.url"
            },
            new Evento(){
                EventoId = 2,
                Tema ="Angular e suas novidades",
                Local = "Sao Paulo",
                Lote = "3 Lote",
                QtdPessoas = 320,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "img1.url"
            }
        };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return  "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return  $"Exemplo de Put id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return  $"Exemplo de Delete id = {id}";
        }
    }
}
