using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteriod : MonoBehaviour
{
    Vector3 rotate;
    Vector3 speed;
    Vector3 locate;
    // Start is called before the first frame update
    void Start()
    {
        rotate.x = Random.Range(0f, 30f);
        rotate.y = Random.Range(0f, 30f);
        rotate.z = Random.Range(0f, 30f);
        GetComponent<Rigidbody>().angularVelocity = rotate;
        speed.x = Random.Range(3f, -3f);
        speed.y = 0f;
        speed.z = Random.Range(-10f, -3f);
        GetComponent<Rigidbody>().velocity = speed;
        locate.x = Random.Range(3f, -3f);
        locate.y = 0f;
        locate.z = 12f;
        GetComponent<Rigidbody>().position = locate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
