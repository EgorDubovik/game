using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
	public SkinnedMeshRenderer body;
	public Mesh meshBody;
	public void OnTriggerEnter(Collider other){
		
		body.sharedMesh = meshBody;
	}
}
