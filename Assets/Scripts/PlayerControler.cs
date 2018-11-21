using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerControler : MonoBehaviour
{
    private CharacterController controller;
    public GameObject bullet;
    [SerializeField]
    private float speed = 10f;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
	}
	
	void FixedUpdate ()
    {
        var movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        controller.Move(movement * speed * Time.deltaTime);
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject clone = Instantiate(bullet, transform.position + Vector3.forward * 1.5f, transform.rotation);
            clone.GetComponent<Rigidbody>().velocity = Vector3.forward * 10f;
            Destroy(clone, 3);
        }
	}
}