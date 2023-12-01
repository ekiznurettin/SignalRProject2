using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.UILayoutCompenents
{
    public class _UILayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
