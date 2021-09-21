using System;
using System.Collections.Generic;
using Core.Application.Commands.Backlogs;
using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApp.Controllers
{
    [Route("api/backlog")]
    [ApiController]
    public class BacklogController: ControllerBase
    {
        private readonly ILogger<WeatherForecastController> logger;
        private readonly IBacklogRepository repository;
        public BacklogController(ILogger<WeatherForecastController> logger, IBacklogRepository repository)
        {
            this.logger = logger;
            this.repository = repository;
        }

        //GET api/backlogs
        [HttpGet]
        public ActionResult <IEnumerable<Backlogs>> GetAll()
        {
            var result = repository.GetAll();

            return Ok(result);
        }

        //GET api/backlogs
        [HttpGet("{id}", Name="GetBacklogById")]
        public ActionResult <Backlogs> GetBacklogById(int id)
        {
            var result = repository.GetBy(id);
            if(result != null)
                return Ok(result);
            else 
                return NotFound();
        }

        //POST api/backlogs
        [HttpPost]
        public ActionResult <Backlogs> CreateBacklog(Backlogs model)
        {
            var result = repository.Insert(model);
            return CreatedAtRoute(nameof(GetBacklogById), new { result.Id }, result);
        }

        //PUT api/backlog
        [HttpPut("{id}")]
        public ActionResult UpdateBacklog(int id, UpdateBacklogCommand model)
        {
            var backlog = repository.GetBy(id);
            if(backlog == null)
                return NotFound();

            backlog.Title = model.Title;
            backlog.Description = model.Description;
            backlog.Priority = model.Priority;
            var result = repository.Update(backlog);

            return Ok(result);
        }
    }
}