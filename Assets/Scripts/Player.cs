using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 mov;
    // Start is called before the first frame update
    void Start()
    {
        print("Hola mundo!");
    }

    // Update is called once per frame
    void Update()
    {

        mov = new Vector2(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical")
           );

        gameObject.transform.position = mov * Time.deltaTime;

    }
}
