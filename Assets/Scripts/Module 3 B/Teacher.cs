using UnityEngine;

namespace AG1934
{
    public class Teacher : Character
    {
        public override void Move()
        {
            Debug.Log(characterName + " is walking to the classroom.");
        }

        public override void Interact()
        {
            Debug.Log(characterName + " is reviewing lesson notes.");
        }

        public override void Communicate()
        {
            Debug.Log(characterName + " says: 'Good morning, class! Let's begin.'");
        }
    }
}
