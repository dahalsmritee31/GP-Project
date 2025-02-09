using UnityEngine;

namespace AG1934
{
    public class HoveringItemSpawner : MonoBehaviour
    {
        public GameObject hoveringItemPrefab; // Assign the Sphere Prefab here
        public Transform spawnPoint; // Optional: Where to spawn the sphere
        public float spawnDelay = 1f; // Time between spawns

        private float timer = 0f;
        void Start()
        {
            Instantiate(hoveringItemPrefab, spawnPoint.position, Quaternion.identity);
        }

        void Update()
        {
            timer += Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space) && timer >= spawnDelay)
            {
                Instantiate(hoveringItemPrefab, spawnPoint.position, Quaternion.identity);
                timer = 0f; // Reset timer
            }
        }
     }
}