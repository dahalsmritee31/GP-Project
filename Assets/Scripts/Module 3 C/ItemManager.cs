using System.Collections.Generic;
using UnityEngine;

namespace AG1934
{
    public class ItemManager : MonoBehaviour
    {
        // A list of all interactable world items in the scene
        public List<IInteractable> interactableItems = new List<IInteractable>();

        // Update is called once per frame
        void Update()
        {
            // Check if the player presses the 'E' key
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Call Interact() for each item in the list
                foreach (IInteractable item in interactableItems)
                {
                    item.Interact();
                }
            }
        }

        // Add an item to the interactable items list
        public void AddItem(IInteractable item)
        {
            if (!interactableItems.Contains(item))
            {
                interactableItems.Add(item);
            }
        }

        // Optionally remove an item from the interactable items list
        public void RemoveItem(IInteractable item)
        {
            if (interactableItems.Contains(item))
            {
                interactableItems.Remove(item);
            }
        }
    }
}
