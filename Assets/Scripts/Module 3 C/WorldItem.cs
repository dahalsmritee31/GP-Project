using UnityEngine;

namespace AG1934
{
    public class WorldItem : Item, ICollectible, IInteractable
    {
        [SerializeField] private float interactionRadius = 2f;
        [SerializeField] private LayerMask whoCanUse;  // Defines who can use the item

        private SphereCollider sphereCollider;

        private void Start()
        {
            // Add a sphere collider for interaction detection
            sphereCollider = gameObject.AddComponent<SphereCollider>();
            sphereCollider.isTrigger = true;
            sphereCollider.radius = interactionRadius;
        }

        public override void Use()
        {
            // Define how the item is used (can be overridden by subclasses)
            Debug.Log($"Using {itemName}...");
        }

        // Make Collect() method virtual so it can be overridden in subclasses
        public virtual void Collect()
        {
            Debug.Log($"{itemName} Collected!");
            Destroy(gameObject); // Removes the item from the world
        }

        // Implement the Interact() method from IInteractable
        public void Interact()
        {
            Debug.Log($"Interacting with {itemName}...");
            // Add interaction behavior here
        }

        private void OnTriggerEnter(Collider other)
        {
            // Check if the item is within the interaction range and if the layer can use it
            if (((1 << other.gameObject.layer) & whoCanUse) != 0)
            {
                Debug.Log($"{other.name} is within range to interact with {itemName}");
            }
        }
    }
}
