using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTriger : MonoBehaviour
{


	public GameObject self;

	public void Start(){
		
	}
   public void OnTriggerEnter(Collider other){
   	Transform t = other.gameObject.transform.Find("BasicMaleDefault/root/pelvis/spine_01/spine_02/spine_03/clavicle_r/upperarm_r/lowerarm_r/hand_r");

   	GameObject newWeapon = FindWeaponByName(self.name,t);

   	

   	if(newWeapon!=null){
   		newWeapon.SetActive(true);
   	
   	} else {
   		Debug.Log("NUll");
   	}
   }


   private GameObject FindWeaponByName(string name, Transform hand){

   	GameObject newWeapon = null;

   	foreach (Transform weapon in hand){
   		if(weapon.tag.Equals("gun")){
   			weapon.gameObject.SetActive(false);
   			Debug.Log($"{weapon.name} SetActive false");
	   		if(name.Equals(weapon.name)){
	   			newWeapon = weapon.gameObject;
	   		}
	   	}
   	}
   	return newWeapon;
   }
}
