using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{   
    public int health = 100;

    public int total;

    //CHALLENGE
    public int playerHealth = 100;

    public GameObject cube;

    //CHALLENGE-1
    public GameObject[] cubes;

    //CHALLENGE - 2
    public GameObject myCube;
    public Vector3[] spawnPoints = new Vector3[5]{new Vector3(0f,2.5f,0f),new Vector3(2.5f,2.5f,0f),new Vector3(0f,2.5f,2.5f),new Vector3(2.5f,0f,0f),new Vector3(0f,0f,2.5f)};
    // Start is called before the first frame update
    void Start()
    {
        Sum(5,2);

        total = sum(4,5);
        Debug.Log("Total = " + total);

        //CHANGE POSITION

        cube.transform.position = new Vector3(0f,2.5f,0f);

        //CHALLENGE - 1
        cubes = GetAllCubes();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            int damage = Random.Range(1,11);
            Damage(damage);
        }
        if(health < 1){
            health = 0;
            Destroy(cube.gameObject);
        }

        if(Input.GetKeyDown(KeyCode.G)){
            changeColor(cube,Color.green);
        }

        //CHANGE POSITION

        if(Input.GetKeyDown(KeyCode.P)){
            changePosition(new Vector3(2.5f,0f,0f));
        }

        if(Input.GetKeyDown(KeyCode.O)){
            cube.transform.position = getPosition();
        }

        //CHALLENGE

        if(Input.GetKeyDown(KeyCode.S) && isDead() == false){
            int damageAmount = Random.Range(1,11);
            DamagePlayer(damageAmount);
        }

        //CHALLENGE - 2
        if(Input.GetKeyDown(KeyCode.F)){
            Vector3 randomPos = GetRandomPos(spawnPoints);
            SetCubePos(randomPos);
        }
    }
    void Sum(int a,int b){
        Debug.Log(a+b);
    }

    void Damage(int damage){
        health -= damage;
        Debug.Log("Health = " + health);
    }

    void changeColor(GameObject cube,Color newColor){
        cube.GetComponent<Renderer>().material.color = newColor;
    }

    private int sum(int a,int b){
        return a+b;
    }

    public void changePosition(Vector3 vector){
        cube.transform.position = vector;
    }

    public Vector3 getPosition(){
        return Vector3.zero;
    }

    //CHALLENGE
    public void DamagePlayer(int damageAmount){
        health -= damageAmount;
        if(isDead() == true){
            playerHealth = 0;
            Debug.Log("Player is dead");
        }
    }

    public bool isDead(){
        return health<1;
    }

    //CHALLENGE - 1
    GameObject[] GetAllCubes(){
        GameObject[] allCubes = GameObject.FindGameObjectsWithTag("Cube");

        foreach(var c in allCubes){
            c.GetComponent<Renderer>().material.color = new Color(Random.value,Random.value,Random.value);
        }
        return allCubes;
    }

    //CHALLENGE - 2
    public Vector3 GetRandomPos(Vector3[] spawnPoints){
        int randomIndex = Random.Range(0,spawnPoints.Length);
        Vector3 randomPos = spawnPoints[randomIndex];
        return randomPos;
    }

    public void SetCubePos(Vector3 randomPos){
        myCube.transform.position = randomPos;
    }

}