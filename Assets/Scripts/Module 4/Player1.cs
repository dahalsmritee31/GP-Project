using UnityEngine;
using AG1934; // if you have a namespace like this

public class Player1 : MonoBehaviour
{
    public Weapon1 equippedWeapon; // This must be PUBLIC

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
