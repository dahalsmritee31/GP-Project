using UnityEngine;

namespace AG1934
{
    public class Bomb : Weapon
    {
        public float throwForce = 10f;

        public override void Equip()
        {
            Debug.Log($"{weaponName} has been equipped!");
        }

        public override void Unequip()
        {
            Debug.Log($"{weaponName} has been unequipped!");
        }

        public override float Attack()
        {
            Debug.Log($"{weaponName} is thrown, dealing {damage} damage!");
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(transform.forward * throwForce, ForceMode.Impulse);
            }
            return damage;
        }
    }
}
