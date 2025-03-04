using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateExplosion : MonoBehaviour
{   
    public GameObject fracturedCrate;
    [SerializeField]
    private float explosionForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)){
            GameObject fracturedCrateObj = Instantiate(fracturedCrate,transform.position,Quaternion.identity);
            Rigidbody[] allRigidBodies = fracturedCrateObj.GetComponentsInChildren<Rigidbody>();
            if(allRigidBodies.Length > 0){
                foreach(var body in allRigidBodies){
                    body.AddExplosionForce(explosionForce,transform.position,3); //last term is explosion radius
                }
            }
            Destroy(this.gameObject);
        }
    }

}