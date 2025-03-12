using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public string name = "Aadidev";
    public int age = 18;
    public bool isMale = true;
    public float speed = 5.5f;
    public Sprite imageIcon;

    //CHALLENGE - 1
    public int bill = 40;
    public float tipPercent = 20f;
    public float totalAmount;

    //CHALLENGE - 2

    public float m1;
    public float m2;
    public float m3;
    public float m4;
    public float m5;
    public float avg;



    // Start is called before the first frame update
    void Start()
    {   

        Debug.Log("My name is " + name);

        //CHALLENGE - 1
        float tipAmount = bill * 20/100;
        totalAmount = bill + tipAmount;
        Debug.Log("Total amount : " + totalAmount);

        //CHALLENGE - 2
        m1 = Random.Range(0f,100f);
        m2 = Random.Range(0f,100f);
        m3 = Random.Range(0f,100f);
        m4 = Random.Range(0f,100f);
        m5 = Random.Range(0f,100f);
        avg = (m1+m2+m3+m4+m5)/5;
        avg = Mathf.Round(avg * 100)/100; //2 decimal places
        Debug.Log("Mark1 : " + m1);
        Debug.Log("Mark2 : " + m2);
        Debug.Log("Mark3 : " + m3);
        Debug.Log("Mark4 : " + m4);
        Debug.Log("Mark5 : " + m5);
        Debug.Log("Average marks = " + avg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}