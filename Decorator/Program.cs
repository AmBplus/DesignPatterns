// See https://aka.ms/new-console-template for more information

using Decorator;

test test = new test();  
  EmailSender emailSender = new EmailSender();
  test.action(emailSender);
ConcereteComponent concereteComponent = new ConcereteComponent();
ConcereteDecorator concerete = new(concereteComponent);
concerete.print();
public  class test
{
   public virtual void action(IEmailSender emailSender)
    {
        emailSender.Send();
        Console.WriteLine("\n------------------------------------------------------\n");
        DecorateIEmailSender decorateIEmailSender = new DecorateIEmailSender(emailSender);
        decorateIEmailSender.Send();
    }

}

public abstract class Component
{
    public virtual void print(){}
}

public class ConcereteComponent : Component
{
    public override void print()
    {
        Console.WriteLine("Concerete Component");
    }
}

public abstract class DecoratorC  : Component
{
    public Component Component;
    public DecoratorC(Component component)
    {
        Component = component;
    }
    public override void print()
    {
        Component.print();
        Console.WriteLine("Decorate CComponent");
    }
    public abstract void NewFeature();
}

public class ConcereteDecorator : DecoratorC
{
    private Component component;
    public ConcereteDecorator(Component component) :base(component)
    {
        
    }
    public override void print()
    {
        base.Component.print();
        Console.WriteLine("ConcereteDecorator Component");
        NewFeature(); 
    }
    public override void NewFeature()
    {

        Console.WriteLine("new f");
    }
}