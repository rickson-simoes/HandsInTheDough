using Balta.ContentContext;
using System;

namespace Balta
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var course = new Course();
			course.Level = ContentContext.Enums.EContentLevel.Beginner;
			foreach(var item in course.Modules)
      {

      }

			var career = new Career();

			Console.WriteLine($"{career.TotalCourses}");
		}
	}
}
