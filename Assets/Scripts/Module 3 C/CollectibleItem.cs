using UnityEngine;

namespace AG1934
{
    public class CollectibleItem : MonoBehaviour, ICollectible
    {
        [SerializeField] private string itemName = "Collectible Coin"; // Item name
        [SerializeField] private int itemValue = 10;  // Value or points associated with the item

        private static int totalScore = 0;  // Static variable to track total score across all collectibles

        private void Start()
        {
            Debug.Log($"{itemName} is available for collection.");
        }

        // This is the same interface method but with a different implementation.
        public void Collect()
        {
            // Instead of destroying, we add the value to the player's score.
            totalScore += itemValue;
            Debug.Log($"Collected {itemName}, Total Score: {totalScore}");

            // Optionally disable the item instead of destroying it.
            gameObject.SetActive(false);
        }

        private void OnTriggerEnter(Collider other)
        {
            // Check if the player collides with the collectible (assuming the player is tagged as "Player")
            if (other.CompareTag("Player"))
            {
                Debug.Log($"{other.name} is close to collect {itemName}");
                Collect();
            }
        }
    }
}
