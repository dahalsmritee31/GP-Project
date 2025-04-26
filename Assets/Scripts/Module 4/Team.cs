using UnityEngine;

namespace AG1934
{
    public class Team : MonoBehaviour
    {
        public Player[] players;  // Aggregation: Team has Players, but Players live separately

        void Start()
        {
            foreach (Player player in players)
            {
                Debug.Log(player.name + " is in the team!");
            }
        }
    }
}