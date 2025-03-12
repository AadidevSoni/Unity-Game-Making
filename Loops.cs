using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{   
    public int apples;

    int i;

    public int points;

    //CHALLENGE - 2
    [SerializeField]
    private int _speed;
    [SerializeField]
    private GameObject _cube;

    [SerializeField]
    private int _maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<10;i++){
            if(i%2 == 0){
                Debug.Log(i);
            }
        }
        //StartCoroutine(AddApplesRoutine());

        //do while loops
        do{
            Debug.Log(i);
            i++;
        }while(i<5);

        //while loop
        //StartCoroutine(loopRoutine());

        while(points < 10){
            Debug.Log(points);
            points++;
        }

        //CHALLENGE - 1

        for(int i=1;i<=30;i++){
            if(i<=10){
                Debug.Log(i);
            }else if(i<=20){
                if(i%2 == 0){
                    Debug.Log(i);
                }
            }else{
                if(i%2 == 1){
                    Debug.Log(i);
                }
            }
        }

        //CHALLENGE - 2
        _maxSpeed = Random.Range(60,121);
        StartCoroutine(incSpeed());
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //CHALLENGE - 2

        _cube.transform.Translate(Vector3.up * _speed * Time.deltaTime);
    }

    IEnumerator AddApplesRoutine(){
        for(int i=1;i<=10;i++){
            apples++;
            Debug.Log("Apples = " + apples);
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator loopRoutine(){
        while(true){
            yield return new WaitForSeconds(1f);
            Debug.Log("Spawning enemy" + i);
            i++;
        }
    }

    IEnumerator incSpeed(){
        while(true){
            yield return new WaitForSeconds(1f);
            _speed += 5;
            if(_speed >= _maxSpeed){
                break;
            }
        }
    }
}