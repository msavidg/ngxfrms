using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ngxFrmsWebApi.Models
{
  public class HomeModel
  {
    public List<FilingRequestStatus> FilingRequestStatuses;

    public int Status { get; set; }

    public HomeModel()
    {
      FilingRequestStatuses = new List<FilingRequestStatus>();
    }

  }
}
