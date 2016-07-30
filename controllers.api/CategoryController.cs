using System.Web.Http;

namespace PTC.controllers.api
{
  public class CategoryController : ApiController
    {
    [HttpGet]
    [Route("api/Category/GetSearchCategories")]
    public IHttpActionResult GetSearchCategories()
    {
      IHttpActionResult ret = null;
      PTCViewModel vm = new PTCViewModel();
      vm.LoadSearchCategories();
      if (vm.SearchCategories.Count > 0)
      {
        ret = Ok(vm.SearchCategories);
      }
      else
      {
        ret = NotFound();
      }

      return ret;
    }
  }
}
