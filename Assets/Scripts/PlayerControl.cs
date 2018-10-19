using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    private Rigidbody m_rb;

	// Use this for initialization
	void Start () {
        m_rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float movement = Input.GetAxis("horizonal");
        m_rb.AddForce(new Vector3(movement, 0.0F, 0.0F));
	}
}
