using ConsoleApp43;

internal class Program
{
    private static void Main(string[] args)
    {
        AbstractHandler xmlHandler = new XMLHandler();
        AbstractHandler txtHandler = new TXTHandler();
        AbstractHandler docHandler = new DOCHandler();

        xmlHandler.Create();
        xmlHandler.Open();
        xmlHandler.Change();
        xmlHandler.Save();

        txtHandler.Create();
        txtHandler.Open();
        txtHandler.Change();
        txtHandler.Save();

        docHandler.Create();
        docHandler.Open();
        docHandler.Change();
        docHandler.Save();
    }
}