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

      using (FrmsEntities frmsEntities = new FrmsEntities())
      {
        var filingRequestStatuses =

          from frs in frmsEntities.ref_FilingRequestStatus

          join frt in frmsEntities.ref_FilingRequestType
            on frs.FilingRequestTypeId
            equals frt.FilingRequestTypeId

          where ((frt.FilingRequestTypeId == (int)EnumFilingRequestType.FFR ||
                  frt.FilingRequestTypeId == (int)EnumFilingRequestType.STATEAPR) && frs.Active.Value)

          orderby frs.OrderInFlow, frs.Name

          select frs;

        foreach (var filingRequestStatus in filingRequestStatuses)
        {
          homeModel.FilingRequestStatuses.Add(new FilingRequestStatus()
          {
            Code = filingRequestStatus.Code,
            FilingRequestStatusId = filingRequestStatus.FilingRequestStatusId,
            Group = filingRequestStatus.Group,
            Name = filingRequestStatus.Name,
            OrderInFlow = filingRequestStatus.OrderInFlow
          });
        }
      }

      return homeModel;
    }

  }
}
