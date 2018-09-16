using System.Threading.Tasks;
using kenely.AuthenticationToken.API.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace kenely.AuthenticationToken.API.Repository
{
  public interface IAuthRepository
  {
    Task<IdentityUser> FindUser(string userName, string password);
    Task<IdentityResult> RegisterUser(UsuarioModel userModel);
  }
}