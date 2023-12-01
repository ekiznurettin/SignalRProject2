using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.MenuNavbarComponents
{
    public class _MenuNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
