using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTacking : MonoBehaviour
{
    public DataRecieve dataRecieve;
    public GameObject[] handPoints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Data points for hands is at position 0-3. position 4 is for gesture (Personal position 4 is for distance)
        // dist created and manipulated
        string data = dataRecieve.data;
        data = data.Remove(0,1);
        data = data.Remove(data.Length-1,1);
        // print(data.Length);

        string[] points = data.Split(',');
        // print(points[3]);

        // float dist = float.Parse(points[3]);

        // x1,y1,z1,x2,y2,z2,x3,y3,z3; 

        for(int i = 0; i < 21; i++)
        {
            // To increase range change the division (example 100 -> 70)
            float x = float.Parse(points[i*4]) /100;
            float y = float.Parse(points[i*4 + 1]) /100;
            float z = float.Parse(points[i*4 + 2]) /1000;

            handPoints[i].transform.localPosition = new Vector3(x, y, z);
        }
    }
}
