using UnityEngine;

namespace AG1934
{
    public class ObjectFinder : MonoBehaviour
    {
        void Start()
        {
            // Manually find objects by name (you can change this to the actual names of your objects)
            GameObject[] objectsToFind = new GameObject[3];

            objectsToFind[0] = GameObject.Find("PuppetCylinder");
            objectsToFind[1] = GameObject.Find("MaliciousEnemy");
            objectsToFind[2] = GameObject.Find("AnotherObject");

            // Loop through the array and change each object's position
            foreach (GameObject obj in objectsToFind)
            {
                if (obj != null)
                {
                    obj.transform.position = new Vector3(0, 10, 0);  // Change position
                    Debug.Log(obj.name + " moved to (0, 10, 0)");
                }
            }
        }
    }
}