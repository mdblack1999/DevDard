using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var projects = new List<Project>
			{
				new Project(1, "تاکسی اینترنتی", "درخواست آنلاین تاکسی برای سفر های درون شهری","project-1.jpg", "MDCO"),
				new Project(1, "زود فود کده", "درخواست آنلاین و سریع غذای سنتی و آماده همراه با مخلفات", "project-6.jpg","zoodFood.Co"),
				new Project(1, "قهوه  آل ایچ", "سرو و ارسال انواع قهوه و دسر و نوشیدنی های گرم و سرد","project-7.jpg", "Alleach"),
				new Project(1, "پوشاک مایا", "ارسال انواع لباس زمستانی و تابستانی مردانه و زنانه در طرح های مختلف","project-4.jpg",
                    "maya")
			};
			return View("_Projects" , projects);
		}
	}
}
