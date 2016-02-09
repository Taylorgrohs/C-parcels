using Nancy;
using Parcel.Objects;

namespace Parcels
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.html"];
      };
      Get["/parcel"] = _ => {

          int Length = 0;
          int.TryParse( Request.Query["Length"], out Length);
          int Width = 0;
          int.TryParse( Request.Query["Width"], out Width);
          int Height = 0;
          int.TryParse( Request.Query["Height"], out Height);
          int Weight = 0;
          int.TryParse( Request.Query["Weight"], out Weight);

          ParcelVariables parcel = new ParcelVariables(Length, Width, Height, Weight);
          if (Length > 0 && Width > 0 && Height > 0 && Weight > 0)
          {
        return View["parcel.html", parcel];
      }
      else
      {
        return View["form.html", parcel];
      }

    };
    }
  }
}
