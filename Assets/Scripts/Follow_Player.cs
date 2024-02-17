using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(x: 0, y: 5, z: -10);
   

   


    private void LateUpdate() 
    {
        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation;
    }

    private void Update()
    {
        
    }

    
}
