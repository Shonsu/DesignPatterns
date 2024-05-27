using System.Net.NetworkInformation;

namespace State;

public class CardInserted : State
{
    public CardInserted(Context context) : base(context)
    {
    }

    public override void EjectCard()
    {
        System.Console.WriteLine("Card ejected");
        _context.ChangeState(new NoCard(_context));

    }

    public override void EnterPin(int pin)
    {
        if (pin == 8888)
        {
            System.Console.WriteLine("Pin entered correctly");
            _context.ChangeState(new PinInserted(_context));
        }
        else
        {
            System.Console.WriteLine("Pin entered incorrectly");
            System.Console.WriteLine("Card ejected");
            _context.ChangeState(new NoCard(_context));
        }

    }

    public override void InsertCard()
    {
        System.Console.WriteLine("Card already inserted");
    }

    public override void WithdrawCash(int amount)
    {
        System.Console.WriteLine("Card already inserted");

    }
}
