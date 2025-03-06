using UnityEngine;

namespace AG1934
{
    public class PuppetCylinder : MonoBehaviour
    {
        public GameObject[] teleportPoints; // Array to hold teleport points
        public float rotationSpeed = 45f;   // Speed of rotation (can be adjusted in the Inspector)

        // Update is called once per frame
        void Update()
        {
            RotateUpAndDown();  // Rotate the puppet up and down every frame
        }

        // Function to rotate the PuppetCylinder up and down
        private void RotateUpAndDown()
        {
            // Rotate the PuppetCylinder around the X-axis (up and down)
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        }

        // Function to move the PuppetCylinder to a random teleport point
        public void MoveToRandomPoint()
        {
            if (teleportPoints.Length > 0) // Check if there are teleport points assigned
            {
                int randomIndex = Random.Range(0, teleportPoints.Length);  // Pick a random index from teleportPoints
                transform.position = teleportPoints[randomIndex].transform.position;  // Teleport the PuppetCylinder
            }
        }
    }
}
