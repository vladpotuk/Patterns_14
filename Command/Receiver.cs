using System;

public class Receiver
{
    public void Action()
    {
        Console.WriteLine("Виконання дії відправника.");
    }

    public void UndoAction()
    {
        Console.WriteLine("Скасування дії відправника.");
    }
}
