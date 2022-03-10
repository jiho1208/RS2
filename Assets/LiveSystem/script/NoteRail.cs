using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteRail : MonoBehaviour
{
    public int NoteSpeed;
    void Start()
    {
        
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.down * Time.deltaTime * NoteSpeed);
    }

}
