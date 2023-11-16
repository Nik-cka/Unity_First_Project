using System.Collections;
using UnityEngine;

namespace Assets.Code
{
    public class DestroyObj : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {   //Создает Стива из Кубов в Unity.
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
}