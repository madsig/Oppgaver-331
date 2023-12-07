namespace OppB
{
    internal interface ICommand
    {
        void Run();
        char Character { get; }
    }
}
