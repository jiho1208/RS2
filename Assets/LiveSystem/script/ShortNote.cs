using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortNote : Note
{
    void Update()
    {
        Move();
        if (isdestroy)
        {
            Destroy(gameObject);
        }
    }
}
