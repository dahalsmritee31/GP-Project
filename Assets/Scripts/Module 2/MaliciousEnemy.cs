using UnityEngine;

namespace AG1934
{
    public class MaliciousEnemy : MonoBehaviour
    {
        private PuppetController controllerToScrewWith; // Reference to the PuppetController
        [SerializeField] private Vector3 maliciousAxis = Vector3.zero; // Axis to affect the controller
        [SerializeField] private float maliciousSpeed = 3.0f; // Speed at which the controller is affected

        private void Start()
        {
            // Find and assign the PuppetController in the scene
            controllerToScrewWith = FindAnyObjectByType<PuppetController>();
        }

        private void FixedUpdate()
        {
            // Check if the PuppetController is assigned
            if (controllerToScrewWith != null)
            {
                // Modify the control vector and speed of the PuppetController
                controllerToScrewWith.controlvector = maliciousAxis;  // Modify the control vector
                controllerToScrewWith.controlspeed = maliciousSpeed;  // Modify the control speed

                // Call the function to update control values in the PuppetController
                controllerToScrewWith.ChangeControlValues();
            }
        }
    }
}


