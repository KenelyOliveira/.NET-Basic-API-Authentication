using kenely.AuthenticationToken.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kenely.AuthenticationToken.API.Repository
{
  public class MenuRepository
  {
    public List<MenuModel> RetornaMenu()
    {
      List<MenuModel> Lista = new List<MenuModel>
            {
                new MenuModel {Id = 1, Descricao = "Dashboard"},
                new MenuModel {Id = 1, Descricao = "Cadastro Produto"},
                new MenuModel {Id = 1, Descricao = "Cadastro Cliente"},
                new MenuModel {Id = 1, Descricao = "Configurações"},
                new MenuModel {Id = 1, Descricao = "Perfil"},
            };

      return Lista;
    }
  }
}
