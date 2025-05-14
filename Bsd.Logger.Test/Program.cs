// See https://aka.ms/new-console-template for more information
using Bsd.Logger;

using (var logger = new ConsoleLogger())
{
    logger.StartThread();

    logger.WriteLine("Hello, World! 1");
    logger.ReWriteLine("Hello, World! 2");
    logger.ReWriteLine("Hello, World! 3");
    logger.ReWriteLine("Hello, World! 4"); 
    logger.WriteLine("Hello, World! 5");
}