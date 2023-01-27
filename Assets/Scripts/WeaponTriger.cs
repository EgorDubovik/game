using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTriger : MonoBehaviour
{


	public GameObject self;
	public WeaponAssets weapons;
	private GameObject person;

   public void OnTriggerEnter(Collider other){
   	GameObject newWeapon = FindWeaponByName(self.name);

   	if(newWeapon!=null){

   		newWeapon.SetActive(true);
   	}
   }


   private GameObject FindWeaponByName(string name){
   	foreach (GameObject weapon in weapons.weapons){
   		weapon.SetActive(false);
   		if(name.Equals(weapon.name)){
   			return weapon;
   		}
   	}
   	return null;
   }
}
