using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats{
    public string name;
    public float fireRate;
    public int ammoCount;

    public WeaponStats(){

    }

    public WeaponStats(string name,float fireRate,int ammoCount){
        this.name = name;
        this.fireRate = fireRate;
        this.ammoCount = ammoCount;
    }
}

public class Classes : MonoBehaviour
{   
    private WeaponStats blasters;
    private WeaponStats rockets;

    // Start is called before the first frame update
    void Start()
    {
        blasters = new WeaponStats();
        blasters.name = "Blasters";
        blasters.fireRate = 0.25f;
        blasters.ammoCount = 100;

        rockets = new WeaponStats("Rockets",5f,2);

        Debug.Log("Current weapon name = " + blasters.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}