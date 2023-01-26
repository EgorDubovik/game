using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	public float moveSpeed = 5f;
	public CharacterController controller;
	public Animator animator;

	void Start()
	{
      controller = GetComponent<CharacterController>();
      animator = GetComponent<Animator>();
   }
        
  void Update()
  {
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Vector3 move = transform.right * x + transform.forward * z;
		controller.Move(move * moveSpeed * Time.deltaTime);

		if(Input.anyKey){
			if(Input.GetKey(KeyCode.W)) animator.SetBool("IsMovingF",true); 
			if(Input.GetKey(KeyCode.S)) animator.SetBool("IsMovingB",true); 
			if(Input.GetKey(KeyCode.A)) animator.SetBool("IsMovingL",true); 
			if(Input.GetKey(KeyCode.D)) animator.SetBool("IsMovingR",true); 
			if(Input.GetMouseButton(0)) animator.SetBool("IsShoot",true); 
		}
		if(Input.GetKeyUp(KeyCode.W)) animator.SetBool("IsMovingF",false); 
		if(Input.GetKeyUp(KeyCode.S)) animator.SetBool("IsMovingB",false);
		if(Input.GetKeyUp(KeyCode.A)) animator.SetBool("IsMovingL",false);
		if(Input.GetKeyUp(KeyCode.D)) animator.SetBool("IsMovingR",false);
   }
}
