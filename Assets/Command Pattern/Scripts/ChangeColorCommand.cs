using UnityEngine;

namespace Command_Pattern.Scripts
{
    public class ChangeColorCommand : ICommand
    {
        private GameObject gameObject;
        private Color previousColor;
        
        public ChangeColorCommand(GameObject gameObject)
        {
            this.gameObject = gameObject;
            previousColor = gameObject.GetComponent<SpriteRenderer>().color;
        }

        public void Execute()
        {
            gameObject.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
        }

        public void Undo()
        {
            gameObject.GetComponent<SpriteRenderer>().color = previousColor;
        }
    }
}