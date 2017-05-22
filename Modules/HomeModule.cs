using Nancy;
using Parcels.Objects;

namespace Nancy
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> View["index.cshtml"];
      Get["/packageInput"] =_=> {
        yourParcel packageVariables = new yourParcel();
        packageVariables.SetDimensions(Request.Query["length"], Request.Query["width"], Request.Query["height"], Request.Query["weight"]);
        return View["output.cshtml", packageVariables];
      }

    }
  }
}
