using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Database;
using Infrastructure;
using SimpleInjector;

namespace WebApi.Controllers
{
    public class TestController : ApiController
    {
        private readonly UnitOfWork _uow;
        public TestController()
        {
            _uow = Bootstrapper.container.GetInstance<UnitOfWork>();
        }

        // GET api/<controller>
        public void Get()
        {
            using (_uow)
            {
                _uow.TestRepo.AddModel("Model1");
                _uow.TestRepo.AddModel("Model2");
                _uow.Save();
            }
            _uow.TestRepo.AddModel("Model3");



        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}