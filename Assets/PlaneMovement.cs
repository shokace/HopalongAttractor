using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;



    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -10)
        {
            Destroy(gameObject); // Destroy this GameObject
        }
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        //transform.Rotate(Vector3.left * speed * 10 * Time.deltaTime);
        //transform.Rotate(Vector3.forward * speed * 10 * Time.deltaTime);


    }
}
