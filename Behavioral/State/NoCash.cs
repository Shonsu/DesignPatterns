namespace State;

public class NoCash : State
{
    public NoCash(Context context) : base(context)
    {
    }

    public override void EjectCard()
    {
        System.Console.WriteLine("Sorry we run out of cash");
    }

    public override void EnterPin(int pin)
    {
        System.Console.WriteLine("Sorry we run out of cash");
    }

    public override void InsertCard()
    {
        System.Console.WriteLine("Sorry we run out of cash");
    }

    public override void WithdrawCash(int amount)
    {
        System.Console.WriteLine("Sorry we run out of cash");
    }
}
