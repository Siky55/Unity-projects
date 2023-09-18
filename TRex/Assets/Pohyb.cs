using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pohyb : MonoBehaviour
{
    public string TextProUpdate = "Bìzí";
    public float speed = 0.01f;
    public Camera kamera;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(this.name+" STARTED");
        //Rigidbody rb = GetComponent<Rigidbody>();
        //rb.AddForce(-500, 0, 0); //uder ze strany na objekt
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(TextProUpdate+": " + this.name);
        Debug.Log(transform.position);

        //if (Input.GetKey("right"))
        //    transform.position += Time.deltaTime * Vector3.right; //deltatime = uplynuly cas (v sekundach) od doby vyvolani Update()
        //if (Input.GetKey("left"))
        //    transform.position += Time.deltaTime * Vector3.left;
        //if (Input.GetKey("up"))
        //    transform.position += Time.deltaTime * Vector3.forward;
        //if (Input.GetKey("down"))
        //    transform.position += Time.deltaTime * Vector3.back;

        if (Input.GetKey("right"))
            transform.Rotate(0, 1f, 0);

        if (Input.GetKey("left"))
            transform.Rotate(0, -1f, 0);

        if (Input.GetKey("up"))
            transform.position += speed * gameObject.transform.forward;

        if (Input.GetKey("down"))
            transform.position -= speed * gameObject.transform.forward;



        //kamera.transform.position = transform.position;
        //kamera.transform.rotation = transform.rotation;

        kamera.transform.position += transform.up;
        kamera.transform.position -= 3*transform.forward;
    }
}
