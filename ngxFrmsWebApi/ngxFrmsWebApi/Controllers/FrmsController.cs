using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ngxFrmsWebApi.DataModels;
using ngxFrmsWebApi.DataModels.Enums;
using ngxFrmsWebApi.Models;

namespace ngxFrmsWebApi.Controllers
{
  public class FrmsController : ApiController
  {
    // https://docs.microsoft.com/en-us/aspnet/web-api/overview/security/enabling-cross-origin-requests-in-web-api


    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]

    public HomeModel GetHomeModel()
    {
      HomeModel homeModel = new HomeModel() { Status = 0 };
      return homeModel;
    }

  }
}
