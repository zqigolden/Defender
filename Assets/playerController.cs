using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    Vector2 movement;
    float fire;
    public GameObject BlotObject;
    public GameObject head;
    int last_fire_time;
    int count;
    public GameObject ast;
    public GameOver gameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count <= 0)
        {
            Instantiate(ast);
            count = Random.Range(20, 100);
        }
        count--;
    }

    private void FixedUpdate()
    {
        float speed = 10;
        //GetComponent<Rigidbody>().AddForce(movement.x * multify * Time.fixedDeltaTime, 0f, movement.y * multify * Time.fixedDeltaTime);
        Vector3 new_position = Vector3.zero;
        float position_x = Mathf.Clamp(transform.position.x + movement.x * speed * Time.fixedDeltaTime, -4.8f, 4.8f);
        float position_z = Mathf.Clamp(transform.position.z + movement.y * speed * Time.fixedDeltaTime, -2.2f, 12f);
        transform.position = new Vector3(position_x, 0f, position_z);
        transform.rotation = Quaternion.Euler(movement.y * 30f, 0f, movement.x * -30f);

        if (fire > 0 && last_fire_time <= 0)
        {
            last_fire_time = 10;
            GameObject bolt = Instantiate(BlotObject, head.transform);
            bolt.transform.parent = null;
        }
        last_fire_time--;
        fire = 0f;
    }

    private void OnMove(InputValue input)
    {
        movement = input.Get<Vector2>();
    }
    void OnFire(InputValue input)
    {
        fire = input.Get<float>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ast"))
        {
            gameOver.Setup(ScoreText.instance.score);
            gameObject.SetActive(false);
        }
    }
}
