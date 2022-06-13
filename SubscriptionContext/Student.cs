using Balta.NotificationContext;
using Balta.SharedContext;
using System.Collections.Generic;
using System.Linq;

namespace Balta.SubscriptionContext
{
  internal class Student : Base
  {

    public Student()
    {
      Subscriptions = new List<Subscription>();
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }
    public IList<Subscription> Subscriptions { get; set; }

    public void CreateSubscription(Subscription subscription)
    {
      if (IsPremium)
      {
        AddNotification(new Notification("Premium", "User already a premium member"));
        return;
      }

      Subscriptions.Add(subscription);
    }
    public bool IsPremium => Subscriptions.Any( Sub => !Sub.IsInactive);
  }
}
