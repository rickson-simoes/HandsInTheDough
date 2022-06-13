using Balta.ContentContext;
using Balta.NotificationContext;
using Balta.SubscriptionContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Balta
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("================= Artigo =================");
      var articles = new List<Article>();
			articles.Add(new Article("Artigo sobre OOP", "Orientacao-Objetos"));
			articles.Add(new Article("Artigo sobre C#", "Csharp"));
			articles.Add(new Article("Artigo sobre .NET", "Dot-net"));

      foreach (var article in articles)
      {
        Console.WriteLine($"{article.Id}, {article.Title}, {article.Url}");
        Console.WriteLine("------");
      }
      Console.WriteLine("================= Curso =================");

      var courses = new List<Course>();
			var courseOOP = new Course("OOP", "Curse-Orientacao-Objetos");
			courseOOP.Level = ContentContext.Enums.EContentLevel.Advanced;

			var courseCSharp = new Course("C#", "Curse-Csharp");
			var courseAspNet = new Course("Asp NET", "Curse-Asp-net");

			courses.Add(courseOOP);
			courses.Add(courseCSharp);
			courses.Add(courseAspNet);


			foreach (var course in courses)
      {
        Console.WriteLine($"{course.Id}, {course.Title}, {course.Url}");
        Console.WriteLine("------");
      }
      Console.WriteLine("================= Carreira -> utilizando order do LINQ =================");

      var careers = new List<Career>();
			var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");

			var careersItem2 = new CareerItem(2, "aprenda oop", "", courseOOP);
			var careersItem = new CareerItem(1, "comece por aqui", "", courseCSharp);
			var careersItem3 = new CareerItem(3, "aprenda asp net", "", null);

			careerDotNet.Items.Add(careersItem2);
			careerDotNet.Items.Add(careersItem);
			careerDotNet.Items.Add(careersItem3);

			careers.Add(careerDotNet);

      foreach (var careerItems in careers)
      {
        Console.WriteLine($"{careerItems.Title}");

        foreach (var careerLists in careerItems.Items.OrderBy(item => item.Order))
        {					
          Console.WriteLine($"{careerLists.Order} - {careerLists.Title}");
          Console.WriteLine($"{careerLists.Course?.Title}");
					Console.WriteLine($"{careerLists.Course?.Level}");

					foreach (var notification in careerLists.Notifications)
          {
						Console.WriteLine($"{notification.Property} - {notification.Message}");
					}
				}
      }

			var paypalSubscription = new PayPalSubscription();
			var student = new Student();

			student.CreateSubscription(paypalSubscription);

		}
	}
}
