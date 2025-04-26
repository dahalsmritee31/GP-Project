using UnityEngine;

namespace AG1934
{
    public class House : MonoBehaviour
    {
        public Room roomPrefab; // assign this from Inspector
        private Room roomInstance;

        void Start()
        {
            roomInstance = Instantiate(roomPrefab, transform);
            roomInstance.Enter();
        }

        void OnDestroy()
        {
            if (roomInstance != null)
            {
                Destroy(roomInstance.gameObject);
            }
            Debug.Log("House destroyed, Room also gone.");
        }
    }
}
