using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuletController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 30f;
    public float damage = 10f;
    public bool isAuto;
    public float fierSpeed;

    public Vector3 firingPoint;
    void Start()
    {
        firingPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }

    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.tag.Equals("Player")){
            Debug.Log(other.gameObject.name);
            other.gameObject.GetComponent<Helth>().GetDamage(damage);
        }
        Destroy(gameObject);
    }
}
