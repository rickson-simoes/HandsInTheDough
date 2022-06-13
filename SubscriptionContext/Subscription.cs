using Balta.SharedContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace Balta.SubscriptionContext
{
  internal class Subscription : Base
  {
    public Plan Plan { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsInactive => EndDate <= DateTime.Now;
  }
}
