using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteRail : MonoBehaviour
{
    LineRenderer line;
    [SerializeField]
    List<Transform> notetransform;
    List<Vector3> notevector = new List<Vector3>();
    void Start()
    {
        line = GetComponent<LineRenderer>();
        notevector.Add(notetransform[0].position);
        notevector.Add(notetransform[1].position);
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        line.SetPosition(0, notevector[0]);
        line.SetPosition(1, notevector[1]);
    }

}
