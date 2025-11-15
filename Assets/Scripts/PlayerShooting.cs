using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public int maxAmmoInGun = 6;
    public int currentAmmoInGun = 6;
    public int ammoReserve = 0;

    public KeyCode reloadKey = KeyCode.R;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        if (Input.GetKeyDown(reloadKey))
        {
            Reload();
        }
    }

    void Shoot()
    {
        if (currentAmmoInGun <= 0)
        {
            Debug.Log("No ammo, reload using R.");
            return;
        }

        currentAmmoInGun=currentAmmoInGun-1;

        // Aici adaugam shooting logic
        Debug.Log("Bang! Ammo loaded: "+currentAmmoInGun);

    }

    public void AddAmmo(int amount)
    {
        ammoReserve=ammoReserve+amount;
    }

    void Reload()
    {
        if (ammoReserve <= 0)
        {
            Debug.Log("No ammo in reserve!");
            return;
        }

        currentAmmoInGun = 0; // Pierdem ce aveam incarcat
        int loadAmount = Mathf.Min(maxAmmoInGun, ammoReserve);
        currentAmmoInGun = loadAmount;
        ammoReserve=ammoReserve-loadAmount;
        Debug.Log("Realoded. Ammo in gun: "+currentAmmoInGun);

    }


}
