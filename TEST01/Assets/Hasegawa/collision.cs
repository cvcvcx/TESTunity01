using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public AudioClip sound;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit!");
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
