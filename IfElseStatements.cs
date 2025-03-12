using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseStatements : MonoBehaviour
{   
    [SerializeField]
    private int _points = 0;
    [SerializeField]
    private bool _hasPrinted = false;

    public int easyDifficulty = 0;
    public int mediumDifficulty = 1;
    public int hardDifficulty = 2;
    public int currentDifficulty;

    //CHALLENGE - 1
    public float m1;
    public float m2;
    public float m3;
    public float m4;
    public float m5;
    public float avg;

    //CHALLENGE - 2
    [SerializeField]
    private GameObject _cube;

    //CHALLENGE - 3
    [SerializeField]
    private float _speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Points = " + _points);
        currentDifficulty = mediumDifficulty;

        if(currentDifficulty == easyDifficulty){
            Debug.Log("You selected easy difficulty");
        }else if(currentDifficulty == mediumDifficulty){
            Debug.Log("You selected medium difficulty");
        }else if(currentDifficulty == hardDifficulty){
            Debug.Log("You selected hard difficulty");
        }else{
            Debug.Log("Invalid difficulty");
        }

        //CHALLENGE - 1

        m1 = Random.Range(0f,100f);
        m2 = Random.Range(0f,100f);
        m3 = Random.Range(0f,100f);
        m4 = Random.Range(0f,100f);
        m5 = Random.Range(0f,100f);
        float avg = (m1+m2+m3+m4+m5)/5;
        avg = Mathf.Round(avg * 100)/100;

        if(avg >= 90){
            Debug.Log("Avg = " + avg + "Grade : A");
        }else if(avg >= 80){
            Debug.Log("Avg = " + avg + "Grade : B");
        }else if(avg >= 70){
            Debug.Log("Avg = " + avg + "Grade : C");
        }else{
            Debug.Log("Avg = " + avg + "Grade : F");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            _points += 10;
            Debug.Log("Points = " + _points);
        }

        if(_points >= 50 && _hasPrinted == false){
            Debug.Log("You are awesome!");
            _hasPrinted = true;
            //CHALLENGE-2
            _cube.GetComponent<Renderer>().material.color = Color.green;
        }

        if(Input.GetKeyDown(KeyCode.T)){
            _speed += 1f;
            if(_speed >= 20f){
                Debug.Log("Slow Down");
            }
        }
        if(Input.GetKeyDown(KeyCode.R)){
            if(_speed >= 1f){
                _speed -= 1f;
            }else{
                Debug.Log("Speed cannot be negative");
            }
        }
        _cube.transform.Translate(Vector3.up * _speed * Time.deltaTime);

        
    }
}