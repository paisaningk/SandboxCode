using System.Collections.Generic;

namespace Command_Pattern.Scripts
{
    //is store all command to use
    public class AllCommand
    {
        private Stack<ICommand> commandsList;

        public AllCommand()
        {
            commandsList = new Stack<ICommand>();
        }

        public void AddCommand(ICommand newCommand)
        {
            newCommand.Execute();
            commandsList.Push(newCommand);
        }

        public void Undo()
        {
            if (commandsList.Count > 0)
            {
                var latestCommand = commandsList.Pop();
                latestCommand.Undo();
            }
        }
    }
}
