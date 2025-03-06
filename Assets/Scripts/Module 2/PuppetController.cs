using UnityEngine;

namespace AG1934
{
    public class PuppetController : MonoBehaviour
    {
        public PuppetCylinder puppet; // Reference to the PuppetCylinder (the puppet object)
        public GameObject targetObject; // The object to find or interact with
        public float moveSpeed = 5f;  // Speed at which the controller sphere moves
        public Vector3 controlvector; // Make controlvector public
        public float controlspeed; // Make controlspeed public

        // Update is called once per frame
        void Update()
        {
            MoveController();  // Move the controller sphere with input

            // Check if the Q key is pressed to interact or find the target object
            if (Input.GetKeyDown(KeyCode.Q))
            {
                FindOrInteractWithObject();
            }
        }

        // Function to move the controller sphere based on input
        private void MoveController()
        {
            float horizontal = Input.GetAxis("Horizontal"); // Get horizontal input (left/right)
            float vertical = Input.GetAxis("Vertical"); // Get vertical input (up/down)

            Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
            transform.Translate(movement); // Move the controller sphere
        }

        // Function to find or interact with an object when the Q key is pressed
        private void FindOrInteractWithObject()
        {
            if (targetObject != null)
            {
                Debug.Log("Found the object! Teleporting puppet...");
                puppet.transform.position = targetObject.transform.position; // Teleport puppet to the target object position
            }
            else
            {
                Debug.Log("No target object assigned.");
            }
        }

        public void ChangeControlValues()
        {
            // Implement any necessary changes to controlvector and controlspeed here, if needed
            // For example:
            Debug.Log("Control Values Changed: " + controlvector + ", Speed: " + controlspeed);
        }
    }
}

