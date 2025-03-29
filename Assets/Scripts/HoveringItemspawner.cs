using UnityEngine;

namespace AG1934
{
    public class HoveringItemSpawner : MonoBehaviour
    {
        public GameObject hoveringItemPrefab; // Prefab of the item to spawn (assign in the inspector)
        public Transform spawnPoint; // Transform that determines where to spawn the item (assign in the inspector)
        public float spawnDelay = 1f; // Delay between spawns (seconds)

        private float timer = 0f;

        void Start()
        {
            // Check if the spawnPoint and hoveringItemPrefab are assigned
            if (spawnPoint != null && hoveringItemPrefab != null)
            {
                // Spawn the item at the start of the game
                Instantiate(hoveringItemPrefab, spawnPoint.position, Quaternion.identity);
            }
            else
            {
                Debug.LogError("HoveringItemSpawner: Missing references! Please assign the 'spawnPoint' and 'hoveringItemPrefab'.");
            }
        }

        void Update()
        {
            timer += Time.deltaTime;

            // Spawn item when space is pressed and spawn delay has passed
            if (Input.GetKeyDown(KeyCode.Space) && timer >= spawnDelay)
            {
                // Check if spawnPoint and hoveringItemPrefab are still assigned
                if (spawnPoint != null && hoveringItemPrefab != null)
                {
                    Instantiate(hoveringItemPrefab, spawnPoint.position, Quaternion.identity);
                    timer = 0f; // Reset timer after spawning
                }
                else
                {
                    Debug.LogError("HoveringItemSpawner: Missing references! Please assign the 'spawnPoint' and 'hoveringItemPrefab'.");
                }
            }
        }
    }
}
