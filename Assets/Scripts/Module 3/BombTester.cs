using UnityEngine;

namespace AG1934
{
    public class BombTester : MonoBehaviour
    {
        void Start()
        {
            // Get the Bomb component attached to the GameObject this script is attached to
            Bomb myBomb = gameObject.GetComponent<Bomb>();

            // Check if the Bomb component is found
            if (myBomb != null)
            {
                myBomb.Equip();  // Activates the bomb (e.g., sets up or prepares it for use)
                myBomb.Attack(); // Simulates throwing the bomb (causes the bomb to move or be thrown in the scene)
                myBomb.Unequip(); // Deactivates the bomb (e.g., cleans up after use or logs)
            }
            else
            {
                Debug.Log("No Bomb component found!"); // Logs if the Bomb component is missing
            }
        }
    }
}
