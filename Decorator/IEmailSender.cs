namespace Decorator;

public interface IEmailSender
{
   void Send();
}
public class EmailSender:IEmailSender{
    public void Send()
    {
        Console.WriteLine("Send Email");
    }
}

public class DecorateIEmailSender : IEmailSender
{
    private IEmailSender EmailSender { get; set;}
        public DecorateIEmailSender(IEmailSender emailSender)
        {
            EmailSender = emailSender; 
        }

        public void Send()
        {
            EmailSender.Send();
            Console.WriteLine("Decorate Email Sender");
        }
}