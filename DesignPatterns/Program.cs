// See https://aka.ms/new-console-template for more information


using DesignPatterns.FactoryPattern;
using DesignPatterns.Singleton;

//SINGLETON PATTERN EXAMPLE
var log = Log.Instance;

log.Save("This is a log message.");
log.Save("This is another log message.");

var singleton = Log.Instance;
var singleton2 = Log.Instance;
Console.WriteLine($"Are both singleton instances the same? {singleton == singleton2}");
Console.ReadLine();

//FACTORY PATTERN EXAMPLE

SaleFactory storeFactory = new StoreSaleFactory(10);
SaleFactory internetFactory = new InternetSaleFactory(5);

ISale storeSale = storeFactory.GetSale();
storeSale.Sell(15);

ISale internetSale = internetFactory.GetSale();
internetSale.Sell(15);
