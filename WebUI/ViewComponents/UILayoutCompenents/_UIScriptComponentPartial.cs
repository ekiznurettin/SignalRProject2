using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.UILayoutCompenents
{
    public class _UIScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
