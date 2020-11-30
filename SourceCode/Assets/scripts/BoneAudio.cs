using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneAudio : MonoBehaviour
{

    private bool grabbed;
    public GameObject BonePart;

    public AudioSource bone_sound;

    private void OnTriggerEnter(Collider other)
    {
        if (grabbed == true)
        {
            bone_sound.Play();

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        bone_sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        grabbed = BonePart.GetComponent<OVRGrabbable>().isGrabbed;
        

    }
}

    
