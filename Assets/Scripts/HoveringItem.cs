using UnityEngine;

namespace AG1934
{
    public class HoveringItem : MonoBehaviour
    {
        public float hoverSpeed = 2f; // Speed of hovering
        public float hoverHeight = 1f; // How high it moves

        private Vector3 startPosition;

        void Start()
        {
            startPosition = transform.position; // Save initial position
        }

        // Update is called once per frame
        void Update()
        {
            float newY = startPosition.y + Mathf.Sin(Time.time * hoverSpeed) * hoverHeight;
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
    }
}

        

        