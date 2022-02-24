using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    public int NoteSpeed;
    public float Perfect = 0.49f;
    public float Great = 0.9f;
    public float Good = 1.19f;
    public float Bad = 1.5f;
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





