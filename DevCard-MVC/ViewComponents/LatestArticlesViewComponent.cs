using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var article = new List<Article>
            {
                new Article(1,"آموزش طراحی سایت حرفه ای و پیشرفته","کامل ترین دوره طراحی سایت و ورود به بازار کار با Asp.Net Core MVC","blog-post-thumb-card-1.jpg"),
                new Article(2,"آموزش جامع javaScript","تنها دوره جامع و فارسی زبان آموزش JavaScript مقدماتی و پیشرفته تا ورود به بازار کار","blog-post-thumb-card-2.jpg"),
                new Article(3,"آموزش Html و css حرفه ای","کامل ترین دوره طراحی سایت و ورود به بازار کار با Html,Css","blog-post-thumb-card-3.jpg"),
                new Article(4,"آموزش زبان برنامه نویسی C# مقدماتی","دوره مقدماتی سی شارپ","blog-post-thumb-card-4.jpg"),
                new Article(5,"آموزش زبان برنامه نویسی C# پیشرفته","دوره پیشرفته سی شارپ","blog-post-thumb-card-5.jpg"),
            };
            return View("_LatestArticles",article);
        }
    }
}
