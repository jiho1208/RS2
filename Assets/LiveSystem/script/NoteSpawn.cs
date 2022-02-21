using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Load()
    {

        TempClass temp = JsonUtility.FromJson<TempClass>("./Resource/temp.json");
        int index = 0;

        Node newNode = temp.nodes[index];

    }
    public enum NoteType
    {
        ShortNote,
        LongNote
    }
    public class TempClass
    {
        public List<Node> nodes = new List<Node>();
    }
    public class Node
    {
        public float time;
        public int position;
        public NoteType type;
    }
}
