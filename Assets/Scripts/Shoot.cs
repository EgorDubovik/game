using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    
    public GameObject fierPlace;
    private GameObject bulet;
    public GameObject[] bulets;
    private CharacterMovement characterMovement;

    void Start(){
        characterMovement = GetComponent<CharacterMovement>();
    }
    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Fire1")){
            if(characterMovement.isGunPickedUp)
                fire();
        }
    }

    void fire(){

        if(characterMovement.equipmentWeapon.Equals("BazookaDefault")){
            bulet = bulets[0];
        } else if(characterMovement.equipmentWeapon.Equals("AssaultRifleDefault")){
            bulet = bulets[1];
        } else {
            bulet = bulets[2];
        }

        GameObject newBulet = Instantiate(bulet, fierPlace.transform.position, fierPlace.transform.rotation);
        Destroy(newBulet,5);
    }

}
