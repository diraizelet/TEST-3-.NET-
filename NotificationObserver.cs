using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_3__.NET_
{
    public interface INotificationObserver
    {
        void Update(string message);
    }

    // Step 2: Implement the EmailNotifier class
    public class EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }

    // Step 2: Implement the SMSNotifier class
    public class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }

    // Step 3: Create the NotificationSubject class
    public class NotificationSubject
    {
        private readonly List<INotificationObserver> _observers = new List<INotificationObserver>();

        public void RegisterObserver(INotificationObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(INotificationObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }
}
