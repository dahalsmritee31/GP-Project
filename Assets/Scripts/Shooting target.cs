using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace AG1934
{
    public class NewMonoBehaviourScript : MonoBehaviour
    {
        [SerializeField] private Transform[] targetEndPoints;

        // Adjust the speed for the application.
        public float speed = 1.0f;

        // The target (cylinder) position.
        private Transform target;

        private int currentEndPointIndex = 0;

        void Start()
        {
            target = targetEndPoints[0];
        }

        // Update is called once per frame
        void Update()
        {
            // Move our position a step closer to the target.
            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            // Check if the position of the cube and sphere are approximately equal.
            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                // Swap the position of the cylinder.
                SwapEndPointTarget();
            }

        }

        void SwapEndPointTarget()
        {
            currentEndPointIndex++;
            currentEndPointIndex %= targetEndPoints.Length;
            target = targetEndPoints[currentEndPointIndex];
        }


    } 
}
