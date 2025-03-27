using UnityEngine;

namespace AG1934
{
    public class TestManager : MonoBehaviour
    {
        public Teacher teacher;
        public Student student;

        // Start is called before the first frame update
        void Start()
        {
            if (teacher != null)
            {
                teacher.Move();
                teacher.Interact();
                teacher.Communicate();
            }

            if (student != null)
            {
                student.Move();
                student.Interact();
                student.Communicate();
            }
        }
    }
}
