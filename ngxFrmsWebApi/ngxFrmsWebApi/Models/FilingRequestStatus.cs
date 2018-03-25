using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ngxFrmsWebApi.Models
{
  public class FilingRequestStatus
  {
    public int FilingRequestStatusId { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public int OrderInFlow { get; set; }
    public string Group { get; set; }

  }
}
