using UnityEngine;

namespace AG1934
{
    public abstract class Character : MonoBehaviour
    {
        public string characterName;

        public abstract void Move();
        public abstract void Interact();
        public abstract void Throw();
    }
}
