using System.ComponentModel;

namespace State;

public abstract class State
{
    protected Context _context;

    protected State(Context context)
    {
        _context = context;
    }

    public abstract void InsertCard();
    public abstract void EjectCard();
    public abstract void EnterPin(int pin);
    public abstract void WithdrawCash(int amount);

}
