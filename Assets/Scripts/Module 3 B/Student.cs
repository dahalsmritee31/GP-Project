using UnityEngine;

namespace AG1934
{
    public class Student : Character
    {
        public override void Move()
        {
            Debug.Log(characterName + " is walking to class.");
        }

        public override void Interact()
        {
            Debug.Log(characterName + " is chatting with friends.");
        }

        public override void Communicate()
        {
            Debug.Log(characterName + " says: 'Did you finish the homework?'");
        }
    }
}
