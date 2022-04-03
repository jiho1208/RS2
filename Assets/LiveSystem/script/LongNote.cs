using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongNote : Note
{

    void Start()
    {
        
    }

    void Update()
    {
        Move();
        if (isdestroy)
        {
            NoteDestroy();
        }
    }
    void OnDestroy()
    {
        NoteDestroy();
    }

    public void NoteDestroy()
    {
        Destroy(transform.parent.gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "EndLine")
        {
            isdestroy = true;
        }
    }


}
