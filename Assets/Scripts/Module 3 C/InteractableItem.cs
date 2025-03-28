using UnityEngine;

namespace AG1934
{
    public class InteractableItem : Item
    {
        // Additional properties for this specific item
        public string interactionMessage = "You can interact with this item!";

        // Override the Use() method to provide custom functionality
        public override void Use()
        {
            // First, call the base class method (the base functionality)
            base.Use();

            // Now, add custom functionality specific to this subclass
            Debug.Log(interactionMessage);
        }
    }
}
