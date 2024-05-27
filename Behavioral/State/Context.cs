namespace State;

public class Context
{
    private State _currentState;
    public int AvailableCash { get; set; } = 2000;

    public void ChangeState(State newState)
    {
        _currentState = newState;
    }
    public Context()
    {
        _currentState = new NoCard(this);
    }

    public void InsertCard()
    {
        _currentState.InsertCard();
    }
    public void EjectCard()
    {
        _currentState.EjectCard();
    }
    public void EnterPin(int pin)
    {
        _currentState.EnterPin(pin);
    }
    public void WithdrawCash(int amount)
    {
        _currentState.WithdrawCash(amount);
    }
}