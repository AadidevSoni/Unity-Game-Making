using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour
{   
    private int selectedLevel;

    //CHALLENGE - 1
    [SerializeField]
    private GameObject _cube;
    private int color;

    //CHALLENGE - 2
    private int _weaponId;
    // Start is called before the first frame update
    void Start()
    {
        selectedLevel = Random.Range(0,3);
    }

    // Update is called once per frame
    void Update()
    {
        switch(selectedLevel){
            case 0:
                Debug.Log("Easy level");
                break;
            case 1:
                Debug.Log("Medium level");
                break;
            case 2:
                Debug.Log("Hard level");
                break;
            default:
                Debug.Log("Invalid level");
                break;
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            selectedLevel = Random.Range(0,3);
        }

        if(Input.GetKeyDown(KeyCode.Alpha1)){
            color = 1; //red
            _weaponId = 0;
        }else if(Input.GetKeyDown(KeyCode.Alpha2)){
            color = 2; //green
            _weaponId = 1;
        }else if(Input.GetKeyDown(KeyCode.Alpha3)){
            color = 3; //blue
            _weaponId = 2;
        }else{
            color = 4;
        }

        switch(color){
            case 1:
                _cube.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                _cube.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 3:
                _cube.GetComponent<Renderer>().material.color = Color.blue;
                break;
            default:
                Debug.Log("Invalid color");
                break;
        }

        //CHALLENGE - 2
        switch(_weaponId){
            case 0: 
                Debug.Log("Gun");
                break;
            case 1:
                Debug.Log("Knife");
                break;
            case 2:
                Debug.Log("Powerup");
                break;
            default:
                Debug.Log("ERROR");
                break;
        }
    }
}