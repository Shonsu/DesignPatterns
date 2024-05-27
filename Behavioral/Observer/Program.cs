using Observer;

var eventPublisher = new EventPublisher();

var s1 = new Subscriber("Adam");
var s2 = new Subscriber("Karolina");
var s3 = new Subscriber("Patrycja");
var s4 = new Subscriber("Tomek");
var s5 = new Subscriber("Michał");
var s6 = new Subscriber("Marcelina");
var s7 = new Subscriber("Damian");

eventPublisher.Subscribe(Category.MOVIE, s1);
eventPublisher.Subscribe(Category.RACE, s2);
eventPublisher.Subscribe(Category.MOVIE, s3);
eventPublisher.Subscribe(Category.CONCERT, s4);
eventPublisher.Subscribe(Category.CONCERT, s5);
eventPublisher.Subscribe(Category.MOVIE, s6);

eventPublisher.Notify("CONCERT");

eventPublisher.Subscribe(Category.CONCERT, s7);

eventPublisher.Notify("CONCERT");

eventPublisher.Notify("MOVIE");
