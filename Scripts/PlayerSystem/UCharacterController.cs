using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UCharacterController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private bool isDebug;
    private const float SPRINT = 5.0f;
    private bool isSprinting = false;

      public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {
        if(isDebug)
        {
            Debug.Log("UCharacterController is attached to " + player.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y != 2f)
        {
            player.transform.position = new Vector3(player.transform.position.x, 2f, player.transform.position.z);
        }

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        player.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        if(Input.GetKey(KeyCode.LeftShift))
            isSprinting = !isSprinting;


        if(Input.GetKey(KeyCode.W))
        {
            if(!isSprinting) player.transform.position += player.transform.forward * Time.deltaTime;
            else player.transform.position += player.transform.forward * Time.deltaTime * SPRINT;
        }
        if(Input.GetKey(KeyCode.S))
        {
            if(!isSprinting) player.transform.position -= player.transform.forward * Time.deltaTime;
            else player.transform.position -= player.transform.forward * Time.deltaTime * SPRINT;
        }
        if(Input.GetKey(KeyCode.A))
        {
            if(!isSprinting) player.transform.position -= player.transform.right * Time.deltaTime;
            else player.transform.position -= player.transform.right * Time.deltaTime * SPRINT;
        }
        if(Input.GetKey(KeyCode.D))
        {
            if(!isSprinting) player.transform.position += player.transform.right * Time.deltaTime;
            else player.transform.position += player.transform.right * Time.deltaTime * SPRINT;
        }

        

    }
}
