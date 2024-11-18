using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNoteScript : MonoBehaviour
{
    private NoteScript activeNote;
    private GameObject interactMessage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactMessage = GameObject.Find("InteractMessage");
        interactMessage.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activeNote)
        {
            if (Input.GetKeyDown("e"))
            {
                activeNote.ToggleNote();
            }
        }
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Note")
        {
            col.gameObject.TryGetComponent(out activeNote);
            interactMessage.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Note")
        {
            if (activeNote.GetNoteStatus())
                activeNote.ToggleNote();
            activeNote = null;
            interactMessage.SetActive(false);
        }
    }
}
