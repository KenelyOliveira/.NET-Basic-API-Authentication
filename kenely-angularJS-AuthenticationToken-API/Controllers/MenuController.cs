using kenely.AuthenticationToken.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace kenely.AuthenticationToken.API.Controllers
{
  [Authorize]
  [RoutePrefix("api/Menu")]
  public class MenuController : BaseController<MenuRepository>
  {
    private MenuRepository _repo = null;

    public MenuController()
    {
      _repo = new MenuRepository();
    }

    [Route("")]
    public IHttpActionResult Get()
    {
      return Ok(_repo.RetornaMenu());
    }
  }
}
