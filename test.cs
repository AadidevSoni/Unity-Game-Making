using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Score.score += 10;   //we can directly access score from Score script as it is static and hence will prolly not get deleted other wise we had to get compoennt to object holding the script and the nget the score
            Debug.Log("Score: " + Score.score);
        }
    }
}