using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTriggers : MonoBehaviour
{

    public KeyCode ribbitKey;

    public AudioSource audioSource;

    public float cooldown = 1;
    private float lastTimePlayed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(ribbitKey) && Time.time - lastTimePlayed > cooldown){
            audioSource.Play();
            lastTimePlayed = Time.time;
        }

    }

    // void OnTrigger(Collider collider){
        
    // }
}
