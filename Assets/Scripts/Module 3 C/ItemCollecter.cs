using UnityEngine;

namespace AG1934
{
    public class ItemCollector : MonoBehaviour
    {
        [SerializeField] private float interactionRadius = 2f;  // Radius to detect interactable items
        [SerializeField] private LayerMask interactableLayer;  // The layer of items that can be collected

        private void Update()
        {
            // Check for user input to collect nearby items
            if (Input.GetKeyDown(KeyCode.E)) // Assuming 'E' is the key to interact
            {
                CollectNearbyItems();
            }
        }

        private void CollectNearbyItems()
        {
            // Find all colliders within the interaction radius
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, interactionRadius, interactableLayer);

            foreach (Collider hitCollider in hitColliders)
            {
                // Check if the collider is interactable (implements ICollectible)
                ICollectible collectible = hitCollider.GetComponent<ICollectible>();

                if (collectible != null)
                {
                    collectible.Collect(); // Call the Collect method if the item is collectible
                }
            }
        }

        private void OnDrawGizmosSelected()
        {
            // Visualize the interaction radius in the editor
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, interactionRadius);
        }
    }
}
