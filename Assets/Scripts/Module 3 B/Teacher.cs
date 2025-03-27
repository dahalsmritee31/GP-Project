using UnityEngine;

namespace AG1934
{
    public class Teacher : Student
    {
        public void Teach()
        {
            Debug.Log($"{studentName} is teaching a lesson.");
        }
    }
}
