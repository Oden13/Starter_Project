using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{ AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
         audio.Play();
    }
}
