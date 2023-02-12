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
    private List<Weapon> weapons;
    private CharacterMovement characterMovement;

    private void Awake() {
        weapons = setWeapons();
    }

    public void EquipWeapon(string name){
        characterMovement = GetComponent<CharacterMovement>();
        GameObject newWeapon = FindWeaponByName(name);
        
        if(newWeapon!=null){
            Weapon weapon = getWeaponFromList(name);
            bulet = bulets[weapon.buletIndex];
            characterMovement.changeAnimationState(weapon.animationState, weapon.typeOfWeapon);
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


    private Weapon getWeaponFromList(string weaponName){
        foreach(Weapon weapon in weapons){
            if(weaponName.Equals(weapon.weaponName)){
                return weapon;
            }
        }
        return weapons[0];
    }

    private List<Weapon> setWeapons(){
        List<Weapon> weapons = new List<Weapon>();
        
        //default weapon setings
        weapons.Add(new Weapon("AssaultRifleDefault", 1, "IdleBattle01_AR", 1));

        weapons.Add(new Weapon("BazookaDefault", 0, "IdleBattle01_BZK", 2));
        weapons.Add(new Weapon("PistolDefault", 2, "IdleBattle01_HG01", 3));
        

        return weapons;
    }

    struct Weapon{
        public string weaponName;
        public int buletIndex;
        public string animationState;
        public int typeOfWeapon; // Тип анимации для смешивания стрелбы
        
        public Weapon(string weaponName, int buletIndex, string animationState, int typeOfWeapon){
            this.weaponName = weaponName;
            this.buletIndex = buletIndex;
            this.animationState = animationState;
            this.typeOfWeapon = typeOfWeapon;
        }

    }
    
}
