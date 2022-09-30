using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{

    public void  OnTriggerEnter(Collider coll) {
        if (coll.CompareTag("Player")) {
            print("gano");
            SceneManager.LoadScene("Ganador", LoadSceneMode.Single);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
    }
}
