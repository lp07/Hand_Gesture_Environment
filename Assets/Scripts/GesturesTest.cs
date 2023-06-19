using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Testing the gestures without the Raspberry Pi Attached
public class GesturesTest : MonoBehaviour
{
    public TMP_Text canvasText;
    public GameObject cube;
    public GameObject plane;
    public GameObject myPrefab;
    public Transform pointZero;
    public bool[] gestures;

    void Update()
    {

        if(gestures[0]){
            var color = plane.GetComponent<Renderer>();
            color.material.SetColor("_Color", Color.white);
            canvasText.text = "Open Hand";
        }

        if(gestures[1]){
            var color = plane.GetComponent<Renderer>();
            color.material.SetColor("_Color", Color.yellow);
            canvasText.text = "Ok Sign";
        }

        if(gestures[2]){
            Instantiate(myPrefab, pointZero.position, Quaternion.identity);
            var color = plane.GetComponent<Renderer>();
            color.material.SetColor("_Color", Color.green);
            canvasText.text = "Thumb Right";
        }

        if(gestures[3]){
            var color = plane.GetComponent<Renderer>();
            color.material.SetColor("_Color", Color.magenta);
            canvasText.text = "Single Finger Gun";
            cube.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,-100));
        }
    }
}
