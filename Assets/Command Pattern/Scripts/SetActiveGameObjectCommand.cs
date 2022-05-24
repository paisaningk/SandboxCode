using UnityEngine;

namespace Command_Pattern.Scripts
{
    public class SetActiveGameObjectCommand : ICommand
    {
        private GameObject gameObject;

        public SetActiveGameObjectCommand(GameObject gameObject)
        {
            this.gameObject = gameObject;
        }
        public void Execute()
        {
            SetActive();
        }

        public void Undo()
        {
            SetActive();
        }

        private void SetActive()
        {
            if (gameObject.activeInHierarchy)
            {
                gameObject.SetActive(false);
            }
            else
            {
                gameObject.SetActive(true);
            }
        }
    }
}