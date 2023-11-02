using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float playerSpeed;

    Rigidbody rigid;


    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
        
    }

    void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        Vector3 moveVec = new Vector3(moveX, 0, moveZ).normalized;

        moveVec = moveVec * playerSpeed * Time.deltaTime;

        transform.Translate(moveVec.x, 0, moveVec.z);

        
    }


}
