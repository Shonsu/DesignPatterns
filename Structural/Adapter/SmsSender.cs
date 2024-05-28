namespace Adapter;

public class SmsSender
{
    public void SendSms(string to, string text)
    {
        System.Console.WriteLine($"Sending SMS to: {to} with message: {text}");
    }
}
