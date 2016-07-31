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

        //[HttpPost()]
        [Route("api/Product/Search")]
        public IHttpActionResult Post(ProductSearch searchEntity)
        {
          IHttpActionResult ret = null;
          PTCViewModel vm = new PTCViewModel();

          vm.SearchEntity = searchEntity;
          vm.Search();
          if (vm.Products.Count > 0)
          {
            ret = Ok(vm.Products);
          }
          else
          {
            ret = NotFound();
          }

          return ret;
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
