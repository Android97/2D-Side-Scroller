using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody m_rb;
    public float speed = 10.0F;
    public float max_speed = 12.0F;

    public float Max_speed { get => max_speed; set => max_speed = value; }

    // Use this for initialization
    void Start()
    {
        m_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal");
        m_rb.AddForce(new Vector3(movement, 0.0F, 0.0F));
    }

    private void fixedUpdate()
    {
        float movement = Input.GetAxis("Horizonal");
        m_rb.AddForce(new Vector3(movement * speed, 0.0F, 0.0F));
        m_rb.velocity = new Vector3(
            Mathf.Clamp(m_rb.velocity.x, -max_speed, max_speed),
            m_rb.velocity.y,m_rb.velocity.z);
    }
}
