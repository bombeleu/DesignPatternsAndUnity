public class Invoker
{
    public Command Command { private get; set; }

    public void ExecuteCommand()
    {
        Command.Execute();
    }
}