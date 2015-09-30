using RestServ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestServ.Controllers
{
   
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Person> Get()
        {
            var personList = new List<Person>();

            for (int i = 0; i < 5; i++)
                personList.Add(new Person
                {
                    Address = "address " + i,
                    Email = "email " + i,
                    FirstName = "firstName "+i,
                    LastName = "lastName "+i,
                    Id = "id " +i                    
                });

            return personList;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
