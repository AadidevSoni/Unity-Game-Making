using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Item{
    public int itemID;
    public string itemName;
    public string description;
}

public class Array : MonoBehaviour
{   
    public string[] weapons;
    public string[] names = new string[3];

    public int[] ages = new int[] {18,19,17,20};

    public int[] weaponID;
    public string[] weapon;

    //DATA REPRESENTATION
    public Item[] myItems;

    //CHALLENGE - 1
    public GameObject _cube1;
    public GameObject _cube2;
    public GameObject _cube3;
    public GameObject[] myCubes;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<ages.Length;i++){
            Debug.Log(ages[i]);
        }

        int randName = Random.Range(0,names.Length);
        Debug.Log(names[randName]);

        foreach(var item in weapon){
            Debug.Log(item);
        }

        //DATA REPRESENTATION
        foreach(var item in myItems){
            Debug.Log(item.description);
        }

        foreach(var item in myItems){
            if(item.itemID == 1){
                Debug.Log("You have " + item.itemName);
            }else{
                Debug.Log("You dont have " + item.itemName);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            for(int i = 0;i<weaponID.Length;i++){
                if(weaponID[i] == 1){
                    Debug.Log(weapon[i]);
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.R)){
            int randomID = Random.Range(0,myItems.Length);
            Debug.Log(myItems[randomID].description);
        }

        //CHALLENGE - 1
        if(Input.GetKeyDown(KeyCode.G)){
            Debug.Log("G is pressed");
            foreach(var cube in myCubes){
                cube.GetComponent<MeshRenderer>().material.color = Color.green;
            }
        }
    }
}