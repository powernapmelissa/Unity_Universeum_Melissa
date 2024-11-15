using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class SlidingWall : MonoBehaviour
{
    Animator anime;

    public GameObject playerObject;
    void Start()
    {
        anime = GetComponent<Animator>();
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(playerObject)
        {
            anime.SetBool("isOpen", true);
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        if(playerObject)
        {
            anime.SetBool("isOpen", false);
        }

    }
}


    
