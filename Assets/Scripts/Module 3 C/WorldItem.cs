using UnityEngine;

namespace AG1934
{
    public class WorldItem : Item
    {
        [SerializeField] private float interactionRadius = 2f;
        [SerializeField] private LayerMask whoCanUse;  // Defines who can interact with the item
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
            // Call base class implementation
            base.Use();

            // Additional behavior for WorldItem
            Debug.Log($"{itemName} is a world item and is now being consumed!");

            // Example: Play a sound effect or remove the item from the world
            Destroy(gameObject);
        }

        private void OnTriggerEnter(Collider other)
        {
            // Check if the other object's layer is within the allowed interaction layers
            if (whoCanUse == (whoCanUse | (1 << other.gameObject.layer)))
            {
                Debug.Log($"{other.name} is within range to interact with {itemName}");
            }
        }
    }
}
