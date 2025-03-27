using UnityEngine;

namespace AG1934
{
    public class ElectricBomb : Bombb
    {
        // Override the Attack method to implement the electric shock behavior
        public override float Attack()
        {
            // Log that the electric bomb is attacking
            Debug.Log($"{weaponName} releases an electric shock, dealing {damage} electric damage!");

            // Optionally, add some visual or sound effects here if desired, e.g.:
            // PlaySoundEffect();
            // SpawnElectricEffect();

            return damage;
        }

        // You can also override other methods like Equip() if needed
        public override void Equip()
        {
            // Log when the ElectricBomb is equipped
            Debug.Log($"{weaponName} has been equipped and is ready to release electric shock!");
        }

        public override void Unequip()
        {
            // Log when the ElectricBomb is unequipped
            Debug.Log($"{weaponName} has been unequipped!");
        }

        // Update method to trigger attack when spacebar is pressed
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
            }
        }
    }
}
