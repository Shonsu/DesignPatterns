using State;

var context = new Context();

context.EjectCard();

context.InsertCard();

context.EnterPin(1234);

context.InsertCard();
context.EnterPin(8888);
context.WithdrawCash(2000);

context.InsertCard();