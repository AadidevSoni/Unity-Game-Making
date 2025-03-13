using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Spell
{
    public string name;
    public int levelRequired;
    public int itemIDRequired;
    public int expGained;

    public Spell(string name,int levelRequired,int itemIDRequired,int expGained){
        this.name = name;
        this.levelRequired = levelRequired;
        this.itemIDRequired = itemIDRequired;
        this.expGained = expGained;
    }

    public void Cast(){
        Debug.Log("Casting " + this.name);

    }
}