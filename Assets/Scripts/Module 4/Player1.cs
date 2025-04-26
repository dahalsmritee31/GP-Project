using UnityEngine;
using AG1934;

public class Player1 : MonoBehaviour
{
    public Weapon1 equippedWeapon;

    void Update()
    {
        // Press Spacebar to Attack
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AttackWithWeapon();
        }
    }

    public void AttackWithWeapon()
    {
        if (equippedWeapon != null)
        {
            equippedWeapon.Attack();
        }
        else
        {
            Debug.Log("No weapon equipped!");
        }
    }
}
