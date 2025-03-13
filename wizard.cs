using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wizard : MonoBehaviour
{   
    public Spell fireBlast;
    public int level;
    public int exp;

    public Spell[] spells;
    void Start()
    {
        fireBlast = new Spell("Fire Blast",1,27,30);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            fireBlast.Cast();
            exp += fireBlast.expGained;
        }

        if(exp >= 100){
            exp = 0;
            level++;
        }

        //CASTING diff spells according to level

        if(Input.GetKeyDown(KeyCode.Alpha2)){
            foreach(var Spell in spells){
                if(Spell.levelRequired == level){
                    Spell.Cast();
                    exp+=Spell.expGained;
                }
                if(level >= 3){
                    int randomIndex = Random.Range(0,spells.Length);
                    spells[randomIndex].Cast();
                    exp += spells[randomIndex].expGained;
                    
                }
            }
        }
    }

}