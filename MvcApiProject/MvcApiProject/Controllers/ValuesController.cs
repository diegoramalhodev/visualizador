using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApiProject.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<int> Get()
        {
            Random rnd = new Random();
            int num = 0;
            bool existe = true;
            List<int> nums = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                existe = true;

                while (existe)
                {
                    num = rnd.Next(1, 61);
                    if (!nums.Contains(num))
                    {
                        nums.Add(num);
                        existe = false;
                    }
                } 
            }
            nums.Sort();

            //return new string[] { rnd.Next(1, 10).ToString(), rnd.Next(1, 10).ToString() };
            return nums;
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