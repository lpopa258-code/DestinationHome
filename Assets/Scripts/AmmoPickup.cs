using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public int ammoAmount = 6;

    void OnTriggerEnter(Collider other)
    {
        PlayerShooting shooter = other.GetComponent<PlayerShooting>();

        if (shooter != null)
        {
            shooter.AddAmmo(ammoAmount);
            Destroy(gameObject);
        }
    }
}
