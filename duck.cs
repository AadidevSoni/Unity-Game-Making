using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duck : Pet
{
    protected override void Speak(){
        Debug.Log("Quack Quack");
    }

    void Start(){
        Speak();
    }
}