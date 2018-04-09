namespace Command
{
    interface ICommand
    {
        void Call();
        void Undo();
    }
}
