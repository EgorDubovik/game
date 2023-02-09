using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTriger : MonoBehaviour
{
	
   	public void OnTriggerEnter(Collider other){
	
		if(other.tag.Equals("Player")){
			other.gameObject.GetComponent<WeaponController>().EquipWeapon(gameObject.name);
			DestroyPlatform();
		}
   }

   private void DestroyPlatform(){
		Destroy(gameObject.transform.parent.parent.gameObject);
   }
}
