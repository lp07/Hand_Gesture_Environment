using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHandByDistance : MonoBehaviour
{
    public DataRecieve dataRecieve;

    public Transform hand;

    public GameObject[] handPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string data = dataRecieve.data;
        data = data.Remove(0,1);
        data = data.Remove(data.Length-1,1);
        // print(data.Length);

        string[] points = data.Split(',');
        // print(points[3]);

        float dist = float.Parse(points[3]);

        hand.Translate(new Vector3(0,0,dist));

    }
}
