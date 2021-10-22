using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bolt : MonoBehaviour
{
    static int score = 0;
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float speed = 10f;
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(new Vector3(transform.position.x, transform.position.y, transform.position.z + speed * Time.fixedDeltaTime));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ast"))
        {
            ScoreText.instance.addScore();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
