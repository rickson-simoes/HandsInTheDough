using Balta.ContentContext;
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
			courses.Add(new Course("OOP", "Curse-Orientacao-Objetos"));
			courses.Add(new Course("C#", "Curse-Csharp"));
			courses.Add(new Course(".NET", "Curse-Dot-net"));

      foreach (var course in courses)
      {
        Console.WriteLine($"{course.Id}, {course.Title}, {course.Url}");
        Console.WriteLine("------");
      }
      Console.WriteLine("================= Carreira -> utilizando order do LINQ =================");

      var careers = new List<Career>();
			var career = new Career("Backend C#", "Backend-CSharp");

			var careersItem2 = new CareerItem(2, "aprenda.net", "", null);
			var careersItem = new CareerItem(1, "aprenda react", "", null);
			var careersItem6 = new CareerItem(6, "aprenda Angular", "", null);
			var careersItem3 = new CareerItem(3, "aprenda Vuejs", "", null);
			var careersItem5 = new CareerItem(5, "aprenda Java", "", null);

			career.Items.Add(careersItem2);
			career.Items.Add(careersItem);
			career.Items.Add(careersItem6);
			career.Items.Add(careersItem3);
			career.Items.Add(careersItem5);

			careers.Add(career);

      foreach (var careerItems in careers)
      {
        Console.WriteLine($"{careerItems.Title}");

        foreach (var careerLists in careerItems.Items.OrderBy( item => item.Order))
        {
          Console.WriteLine($"{careerLists.Order} - {careerLists.Title}");

				}
      }



		}
	}
}
