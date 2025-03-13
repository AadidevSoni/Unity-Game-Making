using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Bank
{
    public string branchName;
    public string location;
    public int cashInVault;

    public void CheckBalance(){
        Debug.Log("Checking balance of " + branchName);
    }

    public void Withdraw(){
        Debug.Log("Withdrawing money from " + branchName);
    }

    public void Deposit(){
        Debug.Log("Depositing money to " + branchName);
    }
}