using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuletController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float damage;
    public bool isAuto;
    public float fierSpeed;
    public GameObject bazukaRocketExplosen;

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
            other.gameObject.GetComponent<Helth>().GetDamage(damage);
        }
        if(gameObject.name.Equals("BazukaBulet(Clone)")){
            Debug.Log(gameObject.name);
            GameObject explosen = Instantiate(bazukaRocketExplosen, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(explosen,1);
        }
        Destroy(gameObject);
    }
}
