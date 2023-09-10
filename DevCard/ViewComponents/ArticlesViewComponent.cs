using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
	public class ArticlesViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			List<Article> articles = new List<Article>()
			{
				new Article(1, "Asp.Net Core", "دوره جامع آموزش فریم ورک Asp.Net با جدید ترین متد ها", "blog-post-thumb-card-1.jpg"),
				new Article(2, "جاوا اسکریپت", "مروری بر مباحث مهم و کاربردی جاواسکریپت در طراحی وب به صورت کاربردی", "blog-post-thumb-card-2.jpg"),
				new Article(3, "هوش مصنوعی", "بررسی اثرات کوتاه مدت و بلند مدت هوش مصنوعی بر کار کرد انسان ها", "blog-post-thumb-card-3.jpg"),
				new Article(4, "یادگیری عمیق", "یادگیری عمیق چیست و چه تفاوتی با یادگیری ماشین کلاسیک دارد؟ کاربرد یادگیری عمیق در پزشکی چیست؟", "blog-post-thumb-card-4.jpg"),
			};
			
			return View("_ArticlesPartialView", articles);
		}
	}
}
