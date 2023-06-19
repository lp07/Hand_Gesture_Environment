using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFlood : MonoBehaviour
{
    public GameObject myPrefab;
    public bool isTrue = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isTrue){
            Instantiate(myPrefab, new Vector3(5,1,2),Quaternion.identity);
        }
    }
}
