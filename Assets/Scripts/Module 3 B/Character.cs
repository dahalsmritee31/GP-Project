using UnityEngine;

namespace AG1934
{
    public abstract class Character : MonoBehaviour
    {
        [SerializeField] protected string characterName; // Now accessible to subclasses

        public abstract void Move();
        public abstract void Interact();
        public abstract void Communicate();
    }
}
