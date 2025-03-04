using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionSlerp : MonoBehaviour
{   
    [SerializeField]
    private Transform _Sphere;
    // Start is called before the first frame update
    void Start()
    {
        //smoothly going to target location
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToFace = _Sphere.position - transform.position;
        Debug.DrawRay(transform.position,directionToFace,Color.green);
        Quaternion targetLocation = Quaternion.LookRotation(directionToFace);

        transform.rotation = Quaternion.Slerp(transform.rotation,targetLocation,Time.deltaTime);

    }
}