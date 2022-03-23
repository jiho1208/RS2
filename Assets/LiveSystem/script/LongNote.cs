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
        if (isdestory)
        {
            NoteDestroy();
        }
    }

    void NoteDestroy()
    {
        Destroy(transform.parent.gameObject);
    }


}
