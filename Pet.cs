using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    protected string petName;
    protected virtual void Speak(){ //lets any inherited class to override this method
        Debug.Log("Speak");
    }
}