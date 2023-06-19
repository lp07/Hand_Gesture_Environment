using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody bullet;
    // Start is called before the first frame update
    void Start()
    {
        bullet = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bullet.velocity = Vector3.back * 5;
    }
}
