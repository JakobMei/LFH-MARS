using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M.A.R.S.Data.DataRepository;
using Microsoft.AspNetCore.Mvc;
using M.A.R.S.Factories.IFactories;
using M.A.R.S.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace M.A.R.S.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KPIConfigController : Controller
    {
        private readonly IRepository Repository;
        private readonly IConfigFactory ConfigFactory;

        //Constructor-Injection, die Services werden aus der Service´Collection der StartUp Klasse gezogen.
        public KPIConfigController(IRepository repository, IConfigFactory configFactory)
        {
            this.Repository = repository;
            this.ConfigFactory = configFactory;
        }
        //// GET: api/<controller>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<controller>/5
        [HttpGet("{username}")]
        public ConfigVM Get(string username)
        {
            var config = this.Repository.GetLastConfig(username);
            return this.ConfigFactory.CreateConfigVM(config);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]ConfigVM configVM)
        {
            var config = this.ConfigFactory.CreateConfig(configVM);
            this.Repository.UpdateUserConfig(config);
        }

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
