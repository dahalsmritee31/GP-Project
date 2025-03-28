using UnityEngine;

namespace AG1934
{
    public abstract class Item : MonoBehaviour
    {
        public string itemName;  // Name of the item
        public GameObject itemPrefab; // Prefab reference
        private KeyCode activationKey = KeyCode.E; // Key to activate item

        // Virtual method that can be overridden by subclasses
        public virtual void Use()
        {
            // Base implementation for using the item (if needed)
            Debug.Log($"{itemName} is being used.");
        }
    }
}
