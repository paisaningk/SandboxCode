namespace Command_Pattern.Scripts
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
