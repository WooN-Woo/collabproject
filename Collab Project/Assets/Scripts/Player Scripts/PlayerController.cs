using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerspeed;
    public int jump;
    Rigidbody rb;
    public CharacterController ch;
    public float gravity = -9.81f;
    Vector3 velocity;

    public Transform gorundcheck;
    public float grounddistance = 0.4f;
    public LayerMask groundmask;

    bool isground;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        move();

    }
    void move()
    {
        isground = Physics.CheckSphere(gorundcheck.position, grounddistance, groundmask);
        if (isground && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        ch.Move(move * playerspeed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        ch.Move(velocity * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isground)
        {
            velocity.y = Mathf.Sqrt(jump * -2f * gravity);
        }
    }

}
