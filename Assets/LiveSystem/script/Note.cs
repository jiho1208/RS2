using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    public int NoteSpeed;
    public bool isdestory;

    void Start()
    {

    }

    void Update()
    {
        Move();
    }



    void Move()
    {
        transform.Translate(Vector3.down * Time.deltaTime * NoteSpeed);
    }

}





