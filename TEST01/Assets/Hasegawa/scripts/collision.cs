using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public AudioClip sound;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cola Can")
        {
            Debug.Log("hit!");
            AudioSource.PlayClipAtPoint(sound, transform.position);
            Destroy(collision.gameObject);
        }
            
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
