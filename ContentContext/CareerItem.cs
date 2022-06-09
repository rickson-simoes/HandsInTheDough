using System;
using System.Collections.Generic;
using System.Text;

namespace Balta.ContentContext
{
  public class CareerItem
  {
    public CareerItem()
    {

    }
    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Course Course { get; set; }
  }
}
