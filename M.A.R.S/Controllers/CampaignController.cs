using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M.A.R.S.ViewModel;
using Microsoft.AspNetCore.Mvc;
using M.A.R.S.Data.DataRepository;
using M.A.R.S.Data.Entities;
using M.A.R.S.Factories;
using M.A.R.S.Factories.IFactories;
using M.A.R.S.PublicEnums;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace M.A.R.S.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampaignController : Controller
    {
        private readonly IRepository Repository;
        private readonly ICampaignFactory CampaignFactory;
        private readonly IPieElementFactory PieElementFactory;

        public CampaignController(IRepository repository,ICampaignFactory campaignFactory, IPieElementFactory pieElementFactory)
        {
            this.Repository = repository;
            this.CampaignFactory = campaignFactory;
            this.PieElementFactory = pieElementFactory;
        }

        // GET: api/<controller>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<controller>/5
        [HttpGet("{username}/{type}")]
        public List<PieElementVM> Get(string username, PieChartType type)
        {
            var campaign = this.Repository.GetCampaign(username);
            if(campaign != null)
            {
                try
                {
                    var pieElements = this.PieElementFactory.CreatePieElements(campaign, type);
                    return pieElements;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return new List<PieElementVM>();
                }
            }
            else
            {
                return new List<PieElementVM>();
            }
            
                   
         }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]ConfigVM campaignVM)
        {
            Campaign campaign = this.CampaignFactory.CreateCampaign(campaignVM);

            this.Repository.SetCampaign(campaign);
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
