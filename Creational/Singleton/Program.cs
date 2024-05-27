// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");

var cfg = Configuration.GetInstance();
var cfg1 = Configuration.GetInstance();

System.Console.WriteLine("Thisa singleton: " + ReferenceEquals(cfg, cfg1));
