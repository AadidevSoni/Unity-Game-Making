using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class customer 
{
    public string firstName;
    public string lastName;
    public int age;
    public string gender;
    public string occupation;

    public customer(string firstName,string lastName,int age,string gender,string occupation){
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
    }
}