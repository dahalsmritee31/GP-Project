using UnityEngine;

namespace AG1934
{
    public class PuppetCylinder : MonoBehaviour
    {
        // Private fields for internal state
        [SerializeField] private GameObject[] teleportPoints; // Points where the object can teleport
        [SerializeField] private float rotationSpeed = 45f;   // Speed of rotation

        // Public property to control access to teleportPoints
        public GameObject[] TeleportPoints
        {
            get { return teleportPoints; }
            set { teleportPoints = value; }
        }

        // Public property to control access to rotationSpeed
        public float RotationSpeed
        {
            get { return rotationSpeed; }
            set { rotationSpeed = Mathf.Max(0, value); } // Preventing negative speed
        }

        void Update()
        {
            RotateUpAndDown();
        }

        private void RotateUpAndDown()
        {
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);  // Rotates up and down
        }

        public void MoveToRandomPoint()
        {
            if (teleportPoints.Length > 0)
            {
                int randomIndex = Random.Range(0, teleportPoints.Length);
                transform.position = teleportPoints[randomIndex].transform.position;
            }
        }
    }
}
