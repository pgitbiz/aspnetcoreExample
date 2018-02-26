﻿namespace PGIT.B2Coin.Web2.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;

    using Data.Services;

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IBoardService _boardService;

        public ValuesController(IBoardService boardService)
            => _boardService = boardService ?? throw new ArgumentNullException();


        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new [] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
