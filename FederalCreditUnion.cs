using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FederalCreditUnion : Bank
{
    public int availableCashToLend;

    public void ApproveLending(){
        Debug.Log("You are awarded a loan");
    }
}