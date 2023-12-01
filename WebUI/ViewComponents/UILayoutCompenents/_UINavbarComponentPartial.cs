using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.UILayoutCompenents
{
    public class _UINavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
