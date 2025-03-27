using UnityEngine;

namespace AG1934
{
    public class BombbTester : MonoBehaviour
    {
        private Bombb bombb;

        void Start()
        {
            bombb = FindObjectOfType<Bombb>(); // Find the Bombb in the scene
        }

        void Update()
        {
            if (bombb != null && Input.GetKeyDown(KeyCode.Space)) // When spacebar is pressed
            {
                bombb.Attack(); // Call the Attack method
            }
        }
    }
}
