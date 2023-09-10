using Microsoft.AspNetCore.Mvc;
using DevCard.Models;

namespace DevCard.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Project> projects = new List<Project>()
            {
                new Project(1, "کنترل فضا پیما", "سامانه کنترل فضاپیما های ناسا", "NASA", "project-1.jpg"),
                new Project(1, "شاد 2", "سامانه مدیریت دانش آموزان", "آموزش و پرورش", "project-2.jpg"),
                new Project(1, "کم ترافیک", "سامانه نمایش نزدیکترین و کم ترافیک ترین مسیر", "Uber", "project-3.jpg"),
                new Project(1, "کودک یار", "سامانه کنترل دسترسی کودکان به سایت ها", "Google", "project-4.jpg"),
            };

            return View("_ProjectsPartialView", projects);
        }
    }
}
