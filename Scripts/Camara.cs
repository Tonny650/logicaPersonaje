using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    public GameObject target;
    public Vector3 v3;
    public float speed;
    public float maxLook;
    public float minLook;
    public Quaternion comRotation;
    
    void Start() {
        comRotation = transform.localRotation;
        
    }

    
    void Update()
    {
        Cam();
    }

    public void Cam() {
        if (target) {
            transform.position = target.transform.position + v3;
        }

        comRotation.y += Input.GetAxis("Mouse X") * speed;
        comRotation.y += Input.GetAxis("Mouse Y") * speed *-1;

        comRotation.x = Mathf.Clamp(comRotation.x, minLook, maxLook);
        
        transform.localRotation = Quaternion.Euler(comRotation.x,comRotation.y, comRotation.z);

    }
}
