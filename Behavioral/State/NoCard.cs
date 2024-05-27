namespace State;

public class NoCard : State
{
    public NoCard(Context context) : base(context)
    {
    }

    public override void EjectCard()
    {
        System.Console.WriteLine("No card inserted.");
    }

    public override void EnterPin(int pin)
    {
        System.Console.WriteLine("No card inserted.");
    }

    public override void InsertCard()
    {
        System.Console.WriteLine("Card Inserted");
        _context.ChangeState(new CardInserted(_context));
    }

    public override void WithdrawCash(int amount)
    {
        System.Console.WriteLine("No card inserted.");
    }
}
