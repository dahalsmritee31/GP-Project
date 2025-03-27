using UnityEngine;

namespace AG1934
{
    // Abstract class comes first
    public abstract class Weapon : MonoBehaviour
    {
        public string weaponName;
        [SerializeField] public float damage = 1.0f;
        [SerializeField] private float modifier = 0.0f;

        // New properties for weapon type and damage type
        public WeaponType weaponType;
        public DamageType damageType;

        public abstract void Equip();
        public abstract void Unequip();
        public abstract float Attack();
    }

    // Enums are placed last
    public enum WeaponType
    {
        Melee,
        Ranged,
        Explosive
    }

    public enum DamageType
    {
        Physical,
        Fire,
        Electric,
        Poison
    }
}
