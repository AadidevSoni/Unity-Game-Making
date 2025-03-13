using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{   
    private WeaponStats blasters;

    void Start()
    {
        blasters = new WeaponStats("Blasters", 0.25f, 50);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            if (ManageUI.Instance != null) { 
                ManageUI.Instance.UpdateWeaponStats(blasters);
            } else {
                Debug.LogWarning("ManageUI instance is null!");
            }

            Destroy(gameObject);
        }
    }
}