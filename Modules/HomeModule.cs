using Nancy;
using System;
using Parcels.Objects;

namespace Nancy
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/packageInput"] = _ => {
        yourParcel packageVariables = new yourParcel();

        float length = 0;
        bool isLengthNumber = float.TryParse(Request.Query["length"], out length);
        bool isWidthNumber = float.TryParse(Request.Query["width"], out length);
        bool isHeightNumber = float.TryParse(Request.Query["height"], out length);
        bool isWeightNumber = float.TryParse(Request.Query["weight"], out length);
        if((isLengthNumber) && (isWidthNumber) && (isHeightNumber) && (isWeightNumber))
        {
          packageVariables.SetDimensions(Request.Query["length"], Request.Query["width"], Request.Query["height"], Request.Query["weight"]);
          return View["output.cshtml", packageVariables];
        }
        else {
          return View["index.cshtml"];
        }



        // if ((Request.Query["length"] != "") && (Request.Query["width"] != "") && (Request.Query["height"] != "") && (Request.Query["weight"] != ""))
        // {
        //   return View["output.cshtml", packageVariables];
        // }
        // else
        // {
        //   private string errorMessage = "Error, Please Enter Appropriate Values!";
        //   return errorMessage;
        // }

      };
    }
  }
}
