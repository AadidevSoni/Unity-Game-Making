using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class ManageUI : MonoBehaviour
{
    public static ManageUI Instance; // ✅ Singleton instance

    public TMP_Text weaponName, fireRate, ammoCount; 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject); // Prevent duplicates
        }
    }

    public void UpdateWeaponStats(WeaponStats weapon)
    {
        if (weapon != null)
        {
            weaponName.text = "Weapon: " + weapon.name;
            fireRate.text = "Fire Rate: " + weapon.fireRate;
            ammoCount.text = "Ammo Count: " + weapon.ammoCount;
        }
        else
        {
            Debug.LogWarning("WeaponStats is null!");
        }
    }
}