using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baile : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator ani;
    public void  OnTriggerEnter(Collider coll) {
        if (coll.CompareTag("GANADOR")) {
            ani.SetBool("dance",true);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
