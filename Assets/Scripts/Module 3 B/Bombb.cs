using UnityEngine;

namespace AG1934
{
    public class Bombb : Weapon
    {
        // Set throw force to apply when the bomb is thrown
        public float throwForce = 10f;

        // Equip method to log when the bomb is equipped
        public override void Equip()
        {
            Debug.Log($"{weaponName} has been equipped!");
        }

        // Unequip method to log when the bomb is unequipped
        public override void Unequip()
        {
            Debug.Log($"{weaponName} has been unequipped!");
        }

        // Attack method to simulate the bomb being thrown and applying force
        public override float Attack()
        {
            Debug.Log($"{weaponName} is thrown, dealing {damage} damage!");

            // Get the Rigidbody component to apply force
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(transform.forward * throwForce, ForceMode.Impulse);
                Debug.Log("Force applied to the bomb.");
            }
            else
            {
                Debug.LogWarning("No Rigidbody found on the Bombb!");
            }

            return damage;
        }
    }
}
