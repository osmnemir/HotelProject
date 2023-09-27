using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _SpinnerPartial:ViewComponent
    {
        public IViewComponentResult Invoke() // default olarak adlandırdığı için ınvoke adını verdik
        {
            return View();
        }
    }
}
