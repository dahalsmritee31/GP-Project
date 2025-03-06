using UnityEngine;

namespace AG1934
{
    public class PuppetController : MonoBehaviour
    {
        public PuppetCylinder puppet; // Reference to PuppetCylinder

        public Vector3 controlvector = Vector3.zero; // Movement direction
        public float controlspeed = 1.0f; // Movement speed

        // Teleport function (already exists)
        public void TeleportPuppet()
        {
            if (puppet != null)
            {
                puppet.MoveToRandomPoint();
            }
        }

        // NEW: Function to apply control changes (called by MaliciousEnemy)
        public void ChangeControlValues()
        {
            if (puppet != null)
            {
                puppet.transform.position += controlvector * controlspeed * Time.deltaTime;
                Debug.Log("MaliciousEnemy is affecting Puppet! Moving in direction: " + controlvector);
            }
        }
    }
}


