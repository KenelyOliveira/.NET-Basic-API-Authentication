using kenely.AuthenticationToken.API.Models;
using kenely.AuthenticationToken.API.Repository;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using System.Web.Http;

namespace kenely.AuthenticationToken.API.Controllers
{
  [AllowAnonymous]
  [RoutePrefix("api/Acesso")]
  public class AcessoController : BaseController<AuthRepository>
  {
    private AuthRepository _repo = null;

    public AcessoController()
    {
      _repo = new AuthRepository();
    }

    [HttpPost]
    public async Task<IHttpActionResult> Login(UsuarioModel usuario)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }
      IdentityResult resultado = await _repo.RegisterUser(usuario);

      IHttpActionResult errorResult = GetErrorResult(resultado);

      if (errorResult != null)
      {
        return errorResult;
      }

      return Ok("Usuário registrado com sucesso");
    }

    
  }
}
