using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerDatabase : MonoBehaviour
{   
    public customer customer1;
    public customer customer2;
    public customer customer3;

    public customer customer4;
    private int i;
    void Start()
    {
        customer1 = new customer("Aadidev","Soni",18,"Male","Game Dev");
        customer2 = new customer("Nael","Saade",20,"Male","AI engineer");
        customer3 = new customer("Asher","Saji",19,"Male","Web Dev");

        customer4 = addCustomer("Ishika","Gupta",18,"Female","Web Dev");
    }

    public customer addCustomer(string firstName,string lastName,int age,string gender,string occupation){
        customer customer4 = new customer("Ishika","Gupta",18,"Female","Web Dev");
        return customer4;
    }


}