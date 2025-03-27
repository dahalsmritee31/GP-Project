using UnityEngine;

namespace AG1934
{
    public class Student : MonoBehaviour
    {
        public string studentName;

        public void Communicate()
        {
            Debug.Log($"{studentName}: Sorry for being late, I missed my bus!");
        }

        public void Move()
        {
            Debug.Log($"{studentName} is moving...");
        }

        public void Interact()
        {
            Debug.Log($"{studentName} is interacting.");
        }
    }
}
