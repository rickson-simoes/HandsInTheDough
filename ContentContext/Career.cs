﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Balta.ContentContext
{
  public class Career : Content
  {
    public Career()
    {
      Items = new List<CareerItem>();
    }
    public List<CareerItem> Items { get; set; }
    public int TotalCourses => Items.Count;
    //expression body
  }
}
