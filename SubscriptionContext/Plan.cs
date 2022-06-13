﻿using Balta.SharedContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace Balta.SubscriptionContext
{
  internal class Plan : Base
  {
    public string Title { get; set; }
    public decimal Price { get; set; }  
  }
}
