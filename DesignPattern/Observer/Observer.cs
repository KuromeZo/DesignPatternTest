// In case you need some guidance: https://refactoring.guru/design-patterns/observer

namespace DesignPattern.Observer
{
    public class ConcreteObserver : IObserver
    {
        //1. Allow to hold the observer's name (e.g. when user Adam wants to observe the subject)
        public string UserName { get; set; }

        //2. Creating the Observer
        public ConcreteObserver(string userName)
        {
            UserName = userName;
        }
        //3. Registering the Observer with the Subject
        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        //4. Removing the Observer from the Subject
        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
        }
        //5. Observer will get a notification from the Subject using the following Method
        public void Update(string availability)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availability + " on Amazon");
        }
    }
}
