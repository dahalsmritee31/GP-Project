using UnityEngine;

namespace AG1934
{
    public class Player : MonoBehaviour
    {
        public string playerName;

        void Awake()
        {
            name = playerName;
        }
    }
}