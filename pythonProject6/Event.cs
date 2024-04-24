//I am e-shop owner. Receive Notification Whenever a Customer Leaves a Message
using System;

// Create a class to pass as an argument for the event handlers (EventArgs class)
public class MessageEventArgs : EventArgs
{
    public string Message { get; }

    public MessageEventArgs(string message)
    {
        Message = message;
    }
}

// Step 2: Set up the delegate for the event
public delegate void MessageReceivedEventHandler(object sender, MessageEventArgs e);

// Step 3: Declare the code for the event
public class MessageNotifier
{
    // Step 5: Associate the event with the event handler
    public event MessageReceivedEventHandler MessageReceived;

    // Simulate receiving a message
    public void ReceiveMessage(string message)
    {
        OnMessageReceived(new MessageEventArgs(message)); // Step 4: Create code that will be run when the event occurs
    }

    protected virtual void OnMessageReceived(MessageEventArgs e)
    {
        MessageReceived?.Invoke(this, e);
    }
}

// Step 4: Create code that will be run when the event occurs (Event Handler)
public class NotificationService
{
    public void OnMessageReceived(object sender, MessageEventArgs e)
    {
        Console.WriteLine($"New message received: {e.Message}");
        Console.WriteLine("Notification sent to user...");
        // Additional notification logic can be added here, such as sending an email or SMS notification
    }
}

class Program
{
    static void Main(string[] args)
    {
        MessageNotifier notifier = new MessageNotifier();
        NotificationService service = new NotificationService();

        // Step 5: Associate the event with the event handler
        notifier.MessageReceived += service.OnMessageReceived;

        // Simulate receiving a message
        notifier.ReceiveMessage("Hello! This is a new message from a customer.");
    }
}
