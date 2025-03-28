using UnityEngine;

namespace AG1934
{
    public class CollectibleItem : Item, ICollectible, IInteractable
    {
        public string itemName = "Magic Stone";  // Name of the item
        public GameObject itemPrefab;  // Prefab reference
        public float interactionRadius = 5f;  // Interaction radius for the item
        private KeyCode activationKey = KeyCode.E; // Key to activate item

        // Implement the Collect() method from ICollectible
        public void Collect()
        {
            Debug.Log($"{itemName} collected!");
            // You can add more logic here, such as adding the item to the player's inventory.
            Destroy(gameObject);  // Destroy the object after collection
        }

        // Implement the Interact() method from IInteractable
        public void Interact()
        {
            Debug.Log($"{itemName} interacted with!");
            // You can add interaction logic here, like using the item or displaying a UI.
        }

        // Override the Use() method from Item class (base class)
        public override void Use()
        {
            Debug.Log($"{itemName} is being used!");
            base.Use();
            // Additional logic can go here (e.g., applying effects, etc.)
        }

        // Optional: Add logic for checking player proximity and activating interaction.
        private void Update()
        {
            // Check if the player is within interaction radius and presses the activation key
            if (Vector3.Distance(transform.position, Camera.main.transform.position) < interactionRadius)
            {
                if (Input.GetKeyDown(activationKey))
                {
                    Interact();  // Call the Interact method when the player presses the key
                }
            }
        }
    }
}
