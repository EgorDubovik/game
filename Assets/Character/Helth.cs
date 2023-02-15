using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helth : MonoBehaviour
{

    private float helthScore;
    public Slider slider;
    private CharacterMovement characterMovement;
    // Start is called before the first frame update
    void Start()
    {   
        characterMovement = GetComponent<CharacterMovement>();
        helthScore = 100f;
        GetDamage(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDamage(float damage){
        // Debug.Log(gameObject.name);
        if(helthScore - damage >0){
            helthScore -= damage;
            characterMovement.getHit();
        }else{
            helthScore = 0;
            Destroy(gameObject,5);
            characterMovement.getDeath();
        }
        
        slider.value = helthScore;

        
    }



}
