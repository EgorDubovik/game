using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	public float moveSpeed = 5f;
	public CharacterController controller;
	public Animator animator;
	public int gunType;
	public bool isGunPickedUp = false;
	public string equipmentWeapon;


	private void Awake() {
		animator = GetComponent<Animator>();	
	}
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

		if(Input.anyKey){
			if(Input.GetKey(KeyCode.W)) {
				animator.SetBool("IsMovingF",true); 
			}
			if(Input.GetKey(KeyCode.S)) animator.SetBool("IsMovingB",true); 
			if(Input.GetKey(KeyCode.A)) animator.SetBool("IsMovingL",true); 
			if(Input.GetKey(KeyCode.D)) animator.SetBool("IsMovingR",true); 
			// if(Input.GetMouseButton(0)) animator.SetBool("IsShooting",true);
		}
		if(Input.GetKeyUp(KeyCode.W)) animator.SetBool("IsMovingF",false); 
		if(Input.GetKeyUp(KeyCode.S)) animator.SetBool("IsMovingB",false);
		if(Input.GetKeyUp(KeyCode.A)) animator.SetBool("IsMovingL",false);
		if(Input.GetKeyUp(KeyCode.D)) animator.SetBool("IsMovingR",false);
		// if(Input.GetMouseButtonUp(0)) animator.SetBool("IsShooting",false);
   }


	public void changeAnimationState(string state, int typeOfWeapon){
		animator.Play(state);
		animator.SetInteger("TypeOfWeapon",typeOfWeapon);
	}
	public void startShooting(){
		animator.SetBool("IsShooting",true);
	}

	public void stopShooting(){
		animator.SetBool("IsShooting",false);
	}

	public void getHit(){
		animator.SetTrigger("Hit");
	}

	public void getDeath(){
		animator.SetBool("IsDeath", true);
	}

   
}
