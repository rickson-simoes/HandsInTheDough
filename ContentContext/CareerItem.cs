﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Balta.ContentContext
{
  public class CareerItem : Base
  {
    public CareerItem(int order, string title, string description, Course course)
    {
      if (course == null)
        throw new Exception("Null not available");

      Order = order;
      Title = title;
      Description = description;
      Course = course;     
    }

    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Course Course { get; set; }
  }
}
