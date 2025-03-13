using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemDatabase : MonoBehaviour
{   
    public Item sword;
    public Item hammer;
    public Item bread;

    public Item[] inventory;


    // Start is called before the first frame update
    void Start()
    {
        sword = new Item("sword",1,"It's really sharp");
        hammer = new Item("Hammer",2,"Breaks through anything");

        bread = createItem("Bread",3,"Yummy");
    }

    private Item createItem(string name,int ID,string description){
        var Item = new Item(name,ID,description);
        return Item;
    }
}