using System.Collections;
using UnityEngine;

namespace Assets.Code
{
    public class DestroyObj : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {  
            //Разрушает объект, на который был применен скрипт.
            Destroy(gameObject)
            

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
