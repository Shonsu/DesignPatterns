using AbstractFactory;

var factory = new Factory(new ScandinavianFactory());
factory.CreateSet();
