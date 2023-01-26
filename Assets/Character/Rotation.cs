using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
	
	void Start()
	{
		
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

		
	}
}
