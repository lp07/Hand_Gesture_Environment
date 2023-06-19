using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gestures : MonoBehaviour
{
    public TMP_Text canvasText;

    public GameObject cube;
    // public GameObject inputField;
    public DataRecieve dataRecieve;
    public GameObject plane;
    public GameObject myPrefab;

    public Transform pointZero;

    // Update is called once per frame
    void Update()
    {

        string data = dataRecieve.data;
        data = data.Remove(0,1);
        data = data.Remove(data.Length-1,1);
        // print(data);

        string[] points = data.Split(',');

        print(points[3]);

        if(int.Parse(points[3]) == 0){
            var color = plane.GetComponent<Renderer>();
            color.material.SetColor("_Color", Color.white);
            canvasText.text = "Open Hand";
        }

        if(int.Parse(points[3]) == 1){
            var color = plane.GetComponent<Renderer>();
            color.material.SetColor("_Color", Color.yellow);
            canvasText.text = "Ok Sign";
        }

        if(int.Parse(points[3]) == 2){
            Instantiate(myPrefab, pointZero.position, Quaternion.identity);
            var color = plane.GetComponent<Renderer>();
            color.material.SetColor("_Color", Color.green);
            canvasText.text = "Thumb Right";
        }

        if(int.Parse(points[3]) == 3){
            var color = plane.GetComponent<Renderer>();
            color.material.SetColor("_Color", Color.magenta);
            canvasText.text = "Single Finger Gun";
            cube.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,-100));
        }
    }
}
