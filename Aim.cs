using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{   
    [SerializeField]
    private Transform _Sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //direction = destination - source
        Vector3 directionToFace = _Sphere.position - transform.position;
        Debug.DrawRay(transform.position,directionToFace,Color.green);
        transform.rotation = Quaternion.LookRotation(directionToFace);
    }
}