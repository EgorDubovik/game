using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	public float moveSpeed = 5f;
	public CharacterController controller;

	void Start()
	{
      controller = GetComponent<CharacterController>();
   }
        
  void Update()
  {
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Vector3 move = transform.right * x + transform.forward * z;
		controller.Move(move * moveSpeed * Time.deltaTime);
   }
}
