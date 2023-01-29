using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTriger : MonoBehaviour
{
	
   public void OnTriggerEnter(Collider other){
   	Transform t = other.gameObject.transform.Find("BasicMaleDefault/root/pelvis/spine_01/spine_02/spine_03/clavicle_r/upperarm_r/lowerarm_r/hand_r");
   	GameObject newWeapon = FindWeaponByName(gameObject.name,t);
   	CharacterMovement playerController = other.gameObject.GetComponent<CharacterMovement>();

   	if(newWeapon!=null){
   		playerController.isGunPickedUp = true;
   		newWeapon.SetActive(true);
   	}
   }


   private GameObject FindWeaponByName(string name, Transform hand){
   	GameObject newWeapon = null;
   	foreach (Transform weapon in hand){
   		if(weapon.tag.Equals("gun")){
   			weapon.gameObject.SetActive(false);
	   		if(name.Equals(weapon.name)){
	   			newWeapon = weapon.gameObject;
	   		}
	   	}
   	}
   	return newWeapon;
   }
}
