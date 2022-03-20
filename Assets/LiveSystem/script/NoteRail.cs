using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteRail : MonoBehaviour
{
    LineRenderer line;
    [SerializeField]
    List<Transform> notetransform;

    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    void Update()
    {
        Setpos();
    }

    void Setpos()
    {
        line.SetPosition(0, notetransform[0].position);
        line.SetPosition(1, notetransform[1].position);
    }

}
