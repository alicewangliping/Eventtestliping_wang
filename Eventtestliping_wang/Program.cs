using Eventtestliping_wang;

public class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();
        MyEventHandlerClass eventHandler = new MyEventHandlerClass();

        // Subscribe to the event using the += operator
        myObject.MyEvent += eventHandler.HandleMyEvent;

        // Call the method that will raise the event
        myObject.DoSomething();
    }
}
