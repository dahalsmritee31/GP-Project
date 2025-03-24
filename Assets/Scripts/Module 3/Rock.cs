using UnityEngine;

namespace AG1934
{
    public class Rock : Weapon
    {
        public float throwForce = 10f;

        public override void Equip()
        {
            // If you want to show when the rock is equipped (e.g., picked up)
            Debug.Log($"{weaponName} has been equipped!");
        }

        public override void Unequip()
        {
            // When you unequip or drop the rock
            Debug.Log($"{weaponName} has been unequipped!");
        }

        public override float Attack()
        {
            // This is where the rock gets thrown
            Debug.Log($"{weaponName} is thrown, dealing {damage} damage!");

            // For demonstration, apply force to the rock if you want it to move.
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(transform.forward * throwForce, ForceMode.Impulse);
            }

            return damage;
        }
    }
}
