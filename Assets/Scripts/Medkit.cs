using UnityEngine;

public class Medkit : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        PlayerHealth hp = other.GetComponent<PlayerHealth>();

        if (hp!=null)
        {
            hp.Heal();
            Destroy(gameObject);
        }
    }
}
