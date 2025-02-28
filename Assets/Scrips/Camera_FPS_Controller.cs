using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Camera_FPS_Controller : MonoBehaviour
{

    public Transform player;
    public float mouseX;
    public float mouseY;
    public float sencitivily;

    public float xRotation;

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sencitivily * Time.deltaTime; 
        mouseY = Input.GetAxis("Mouse Y") * sencitivily * Time.deltaTime; 

        player.Rotate( player.transform.up * mouseX);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -50, 50);

        transform.localRotation = Quaternion.Euler(xRotation,0,0);
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
