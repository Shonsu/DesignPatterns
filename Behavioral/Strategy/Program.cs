using Strategy;

var strategy = new CarStrategy();
var map = new Map(strategy);
var start = new Coordinate() { Long = 123.123, Lat = 123.123 };
var end = new Coordinate() { Long = 1.2, Lat = 5.123 };
map.CreateRoute(start, end);
