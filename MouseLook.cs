using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{   
    [SerializeField]
    public float _mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //lock cursor to centre of screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;

        //LOOK LEFT AND RIGHT
        playerBody.Rotate(Vector3.up * mouseX); // to look left-right we have to rotate along Y axis, hence Vector3.up

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-90f,90f); //so that player can never look behind the player 
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
    }
}