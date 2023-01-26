using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
	public Animator animator;
	void Start()
	{
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out RaycastHit hitInfo, maxDistance: 300f)){
			var target = hitInfo.point;
			target.y = transform.position.y;
			transform.LookAt(target);
		}

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
