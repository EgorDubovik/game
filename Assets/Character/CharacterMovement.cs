using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	public float moveSpeed = 5f;
	public float rotationSpeed = 5f;
	public CharacterController controller;
	public Animator animator;
	Vector3 oldPos;
	Quaternion oldRot;

	void Start()
	{
		animator = GetComponent<Animator>();
      controller = GetComponent<CharacterController>();

      oldPos = transform.position;
    	oldRot = transform.rotation;
   }
        
  void Update()
  {
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Vector3 move = transform.right * x + transform.forward * z;
		controller.Move(move * moveSpeed * Time.deltaTime);


		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out RaycastHit hitInfo, maxDistance: 300f)){
			var target = hitInfo.point;
			target.y = transform.position.y;
			transform.LookAt(target);
		}

		if(Input.GetKey(KeyCode.W)) animator.SetBool("IsMovingF",true); else animator.SetBool("IsMovingF",false);
		if(Input.GetKey(KeyCode.S)) animator.SetBool("IsMovingB",true); else animator.SetBool("IsMovingB",false);
		if(Input.GetKey(KeyCode.A)) animator.SetBool("IsMovingL",true); else animator.SetBool("IsMovingL",false);
		if(Input.GetKey(KeyCode.D)) animator.SetBool("IsMovingR",true); else animator.SetBool("IsMovingR",false);
		if(Input.GetMouseButton(0)) animator.SetBool("IsShoot",true); else animator.SetBool("IsShoot",false);


		

     //Camera.main.transform.position.y
   //   Vector3 cursorPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
   //   Debug.Log(cursorPos);
	  // cursorPos.y = transform.position.y;
	  // Vector3 lookDirection = cursorPos - transform.position;
	  // Quaternion rotation = Quaternion.LookRotation(lookDirection);
	  // transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);

   }
}
