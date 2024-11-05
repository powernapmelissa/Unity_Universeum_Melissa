using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    //bool(true or false), indicates if the door is closed or not. Closed = true = Dörren är stängd
    public bool closed = true;
    //Skapar en float(decimaltal), med graden som dörren öppnas. Glöm ej F efter talet!!!
    public float openDegrees = 90f;
    //Skapar float variabel för hastigheten som dörren öppnas i. 
    public float openSpeed = 60f;

    //private variables
    
    //Variabel that stores the Y-axis degrees when the door is closed
    float closedDegrees;
    //Variabel represent the 3D-angle of the door when its closed. Euler= math xyz blabla
    Vector3 closedEulerAngles;
    //-ll- but open
    Vector3 openedEuelerAngles;
    
    void Start()
    {
        //retrieves the current Y-axis rotation of the GameObject (the door) in its local coordinate space.
        closedDegrees = transform.localEulerAngles.y;
        //New meaning of variabel, 0 in x, closeddegrees in y, 0 in z
        closedEulerAngles = new Vector3(0f, closedDegrees, 0f);
        //Calling of openDegrees in y-axis(90f)
        openedEuelerAngles = new Vector3(0f, closedDegrees + openDegrees, 0f);
    }

    
    void Update()
    {
        //checks if door is closed
        if (closed)
            //fetches the current position, target: closedEulerAngles (the desired closed position), Time.deltaTime is the time elapsed since the last frame, ensuring that the movement is smooth and frame rate-independent.
            transform.localEulerAngles = Vector3.MoveTowards(transform.localEulerAngles, closedEulerAngles, openSpeed * Time.deltaTime);

        else
            transform.localEulerAngles = Vector3.MoveTowards(transform.localEulerAngles, openedEuelerAngles, openSpeed * Time.deltaTime);
        
    }

    //public method ToggleOpen, can change the state of object, closed or opened
    public void ToggleOpen()
    { 
        // !closed inverts closed, the door is opened.
        closed = !closed; 
    }
}
