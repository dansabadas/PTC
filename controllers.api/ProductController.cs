using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PTC.controllers.api
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        public IHttpActionResult Get()
        {
          IHttpActionResult ret = null;
          PTCViewModel vm = new PTCViewModel();
          vm.Get();
          if(vm.Products.Count > 0)
          {
            ret = Ok(vm.Products);
          }
          else
          {
            ret = NotFound();
          }

          return ret;
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
