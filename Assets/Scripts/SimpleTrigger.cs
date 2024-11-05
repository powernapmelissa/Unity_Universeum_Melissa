using UnityEngine;
using UnityEngine.Events;

public class SimpleTrigger : MonoBehaviour
{
    //creates a bool variabel(sant/falskt/on/off) which can destroy the gameobject once triggered
    public bool destroyOnTrigger;
    // creates a string variabel (text) which specifies which tag the object must have in order
    // for the trigger to work
    public string tagFilter;

    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;

    // private (method can only be called withín this class. (void) method with no return value.
    // (OnTriggerEnter) Unity calls this when a collider object enters the trigger
    // (Collider other) represents the collider object and it´s properties, tags, name etc
    
    private void OnTriggerEnter(Collider other)
    {
        // if other(collider object).CompareTag(compares the right tag) tagFilter(compares with 
        // the string)
        if (other.CompareTag(tagFilter))
        {
            //onTriggerExit: This is a UnityEvent declared earlier in the script.
            //Invoke(): This method calls all methods that have been registered to this UnityEvent.
            //So, when a collider with the specified tag exits the trigger, all attached functions
            //will be executed.
            onTriggerExit.Invoke();
            if (destroyOnTrigger)
                Destroy(gameObject);
        }
        
    }
}
