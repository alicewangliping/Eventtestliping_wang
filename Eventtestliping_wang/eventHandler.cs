namespace Eventtestliping_wang
{
    public delegate void testEventHandler(object sender, MyEventArgs e);
    // Set up the delegate for the event

    public class MyEventArgs : EventArgs
    {
        public string Message { get; set; }

        public MyEventArgs(string message)
        {
            Message = message;
        }
    }
    //Create a class to pass as an argument for the event handlers (EventArgs class)


    //  Declare the code for the event
    public class MyClass
    {
        public event testEventHandler MyEvent;

        public void DoSomething()
        {
            // Do some work...
            string message = "Work done";

            // 4) Create code that will be run when the event occurs (Event Handler)
            OnMyEvent(new MyEventArgs(message));
        }

        protected virtual void OnMyEvent(MyEventArgs e)
        {
            // 5) Associate the event with the event handler
            MyEvent?.Invoke(this, e);
        }
    }

    // Another class which handles the event
    public class MyEventHandlerClass
    {
        public void HandleMyEvent(object sender, MyEventArgs e)
        {
            Console.WriteLine("Event occurred: " + e.Message);
        }
    }
}
