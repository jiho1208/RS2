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
        if(transform.position.z == 0)
        {
            isdestroy = true;
        }
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


}
