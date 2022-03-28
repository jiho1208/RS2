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
            isdestory = true;
        }
        if (isdestory)
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
