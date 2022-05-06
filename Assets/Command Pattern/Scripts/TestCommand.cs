using System;
using UnityEngine;

namespace Command_Pattern.Scripts
{
    public class TestCommand : MonoBehaviour
    {
        public new GameObject gameObject;
        private AllCommand allCommand;

        private void Start()
        {
            allCommand = new AllCommand();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ICommand command = new SetActiveGameObjectCommand(gameObject);
                allCommand.AddCommand(command);
            }
            
            if (Input.GetKeyDown(KeyCode.R))
            {
                ICommand command = new ChangeColorCommand(gameObject);
                allCommand.AddCommand(command);
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                allCommand.Undo();
            }
        }
    }
}
