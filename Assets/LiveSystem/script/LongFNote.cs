using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongFNote : LongNote
{
    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    void OnDestroy()
    {
        NoteDestroy();
    }
}
