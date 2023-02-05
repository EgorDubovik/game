using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    public int gunType;
	public bool isGunPickedUp = false;
	public string equipmentWeapon;
    public GameObject hand_r;
    public GameObject[] bulets;
    public GameObject bulet;

    public void EquipWeapon(string name){
        GameObject newWeapon = FindWeaponByName(name);
        
        if(newWeapon!=null){
            setBulet(name);
            isGunPickedUp = true;
            equipmentWeapon = name;
            newWeapon.SetActive(true);
        }
    }

    private GameObject FindWeaponByName(string name){
        GameObject newWeapon = null;
        foreach (Transform weapon in hand_r.transform){
            if(weapon.tag.Equals("gun")){
                weapon.gameObject.SetActive(false);
                if(name.Equals(weapon.name)){
                    newWeapon = weapon.gameObject;
                }
            }
        }
        return newWeapon;
   }

   private void setBulet(string weaponName)
   {
        if(weaponName.Equals("BazookaDefault")){
            bulet = bulets[0];
        } else if(weaponName.Equals("AssaultRifleDefault")){
            bulet = bulets[1];
        } else {
            bulet = bulets[2];
        }

   }
    
}
