using UnityEngine;

namespace AG1934
{
    public class RockTester : MonoBehaviour
    {
        void Start()
        {
            Rock myRock = gameObject.GetComponent<Rock>();

            if (myRock != null)
            {
                myRock.Equip();  // Equips the rock
                myRock.Attack(); // Throws the rock
                myRock.Unequip(); // Unequips the rock
            }
            else
            {
                Debug.LogError("No Rock component found on this GameObject!");
            }
        }
    }
}
