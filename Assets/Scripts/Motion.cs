using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    private CharacterController controller;
    private float speed = 0.5f;
    private float angularSpeed = 1f;
    private float rx, ry;
    public GameObject playerCamera; // public allows to init this object FROM UNITY !!!

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(0, 0, 0.01f));
        float dx, dz;

        // Mouse input
        //vertical rotation
        rx -= Input.GetAxis("Mouse Y") * angularSpeed;
        //runs on Player camera
        playerCamera.transform.localEulerAngles = new Vector3(rx, 0, 0);

        //horizontal rotation
        ry = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * angularSpeed;
        //runs on this(Player)
        transform.localEulerAngles = new Vector3(0, ry, 0);


        // Keyboard input
        dx = Input.GetAxis("Horizontal") * speed;
        dz = Input.GetAxis("Vertical") * speed;
        Vector3 motion = new Vector3(dx, -1, dz);
        motion = transform.TransformDirection(motion);
        controller.Move(motion);
    }
}