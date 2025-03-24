using UnityEngine;

namespace AG1934
{
    
    public abstract class Weapon : MonoBehaviour
    {
        public string weaponName;
        [SerializeField] public float damage = 1.0f;
        [SerializeField] private float modifier = 0.0f;
        //[SerializeField] private bool isnotUsable = false;

        public abstract void Equip();

        public abstract void Unequip();

        public abstract float Attack();
    }
}

