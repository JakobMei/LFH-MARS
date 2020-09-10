using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M.A.R.S.Data.DataRepository;
using M.A.R.S.Factories.IFactories;
using M.A.R.S.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace M.A.R.S.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestController : Controller
    {
        private readonly IRepository Repository;
        private readonly IRequestFactory RequestFactory;

        public RequestController(IRepository repository, IRequestFactory requestFactory)
        {
            this.RequestFactory = requestFactory;
            this.Repository = repository;
        }


        //// GET: api/<controller>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<controller>/5
        [HttpGet("{username}")]
        public CampaignRequestVM Get(string username)
        {
            var request = this.Repository.GetLatestRequest(username);
            var requestVM = this.RequestFactory.CreateRequestVM(request);
            return requestVM;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] CampaignRequestVM requestVM)
        {
            var request = this.RequestFactory.CreateRequest(requestVM);
            this.Repository.SetRequest(request);
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
