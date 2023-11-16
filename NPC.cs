using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class NPC : MonoBehaviour
{



    //Health NPC
    public int health = 5;



    //Level NPC

    public int level = 1;
  
    
    
    //Speed NPC
    public float speed = 1.2f;

    //Special data type. It can take the position of the object
    private Vector3 Vector3newPosition;




    // Start is called before the first frame update
    void Start()
    {
        //We are adding "level" to "health" - creating new health.
        health += level;
        
        

    }

    // Update is called once per frame
    void Update()
    {
        //Prisvaivaem nach.position
        Vector3 newPosition = transform.position;
        //We are just adding special command 
        newPosition.z += speed * Time.deltaTime;
        //Prisvaivaem new value for transform.position.
        transform.position = newPosition;

    }
}
