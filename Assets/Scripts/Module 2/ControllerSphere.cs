using UnityEngine;

namespace AG1934
{
    public class ControllerSphere : MonoBehaviour
    {
        public PuppetCylinder puppet; // Reference to PuppetCylinder

        // Start is called before the first frame update
        void Start()
        {
            // Any initialization you need for the Controller can go here
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                puppet.MoveToRandomPoint(); // Call MoveToRandomPoint on PuppetCylinder
            }
        }
    }
}
