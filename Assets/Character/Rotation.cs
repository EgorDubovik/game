using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
	float camRayLength = 100f;
	int floorMask;
	void Start()
	{
		floorMask = LayerMask.GetMask ("Floor");
		
	}

	// Update is called once per frame
	void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit floorHit;
		if(Physics.Raycast(ray, out floorHit, camRayLength, floorMask)){

			// Vector3 playerToMouse = floorHit.point - transform.position;
			// playerToMouse.y = 0f;
			// Quaternion newRotatation = Quaternion.LookRotation (playerToMouse);
			// playerRigidbody.MoveRotation (newRotatation);
			
			var target = floorHit.point;
			target.y = transform.position.y;
			transform.LookAt(target);
		}

		
	}
}
