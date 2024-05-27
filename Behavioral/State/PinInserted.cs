namespace State;

public class PinInserted : State
{
    public PinInserted(Context context) : base(context)
    {
    }

    public override void EjectCard()
    {
        System.Console.WriteLine("Card ejected");
        _context.ChangeState(new NoCard(_context));
    }

    public override void EnterPin(int pin)
    {
        System.Console.WriteLine("You have already inserted correct pin.");
    }

    public override void InsertCard()
    {
        System.Console.WriteLine("Card already inserted");
    }

    public override void WithdrawCash(int amount)
    {
        if (amount > _context.AvailableCash)
        {
            System.Console.WriteLine("Amount of cash not available");
        }
        else
        {
            System.Console.WriteLine($"Withdraw {amount} from machine");
            _context.AvailableCash -= amount;
            if (_context.AvailableCash == 0)
            {
                _context.ChangeState(new NoCash(_context));
            }
            else
            {
                System.Console.WriteLine("Card ejected");
                _context.ChangeState(new NoCard(_context));
            }
        }

    }
}