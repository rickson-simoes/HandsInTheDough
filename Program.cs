using Balta.ContentContext;
using Balta.NotificationContext;
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
			var courseCSharp = new Course("C#", "Curse-Csharp");
			var courseDotNet = new Course(".NET", "Curse-Dot-net");

			courses.Add(courseOOP);
			courses.Add(courseCSharp);
			courses.Add(courseDotNet);

			// PAREI AQUI ONDE FIZ O PROCESSO DE NOTIFICATIONCONTEXT, ONDE UM VAI HERDANDO DO OUTRO TENDO ACESSO AOS DADOS E ETC... É BOM OLHAR NOVAMENTE O VIDEO SÓ PARA TER UMA BASE DO QUE FOI FEITO, MAS É BEM DE BOA.

			// O MÉTODO 'ADD' do courseOOP é do Notifiable.cs de dentro de NotificationContext

			//courseOOP.Add(new Notification("a", "asdas"));


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
			var careersItem3 = new CareerItem(3, "aprenda .net", "", courseDotNet);

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
          Console.WriteLine($"{careerLists.Course.Title}");
					Console.WriteLine($"{careerLists.Course.Level}");
				}
      }



		}
	}
}
