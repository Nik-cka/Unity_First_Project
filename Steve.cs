using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    // Создает Стива из Блоков в Unty.
    GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0,0,0);
    GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f,1,0);
    GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f,1,0);
    GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f,2,0);
    GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f,2,0);
    GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0,3,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
