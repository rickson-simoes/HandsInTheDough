using Balta.SharedContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace Balta.SubscriptionContext
{
  internal class Student : Base
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public User user { get; set; }
  }
}
