using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    private float speed = 17.5f;
    // Start is called before the first frame update
    void Start()
    {
        //Current position = new position;
        //transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
    private void movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime);

        if (transform.position.y < -4)
        {
            transform.position = new Vector3(transform.position.x, -4, 0);
        }
        else if (transform.position.y > 4)
        {
            transform.position = new Vector3(transform.position.x, 4, 0);
        }

        if (transform.position.x > 8)
        {
            transform.position = new Vector3(-8, transform.position.y, 0);
        }
        else if (transform.position.x < -8)
        {
            transform.position = new Vector3(8, transform.position.y, 0);
        }
    }
}
