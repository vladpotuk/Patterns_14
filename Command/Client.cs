public class Client
{
    public void Run()
    {
        Receiver receiver = new Receiver();
        ICommand command = new ConcreteCommand(receiver);
        Invoker invoker = new Invoker();

        invoker.SetCommand(command);
        invoker.ExecuteCommand();
        invoker.UndoCommand();
    }
}
