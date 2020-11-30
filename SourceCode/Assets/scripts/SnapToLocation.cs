using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToLocation : MonoBehaviour
{

    private bool grabbed;

    private bool insideSnapZone;

    public bool Snapped;

    public GameObject BonePart;

    public GameObject SnapRotationReference;

    public AudioSource snapaudio;


    private void OnTriggerEnter(Collider other){
	if (other.gameObject.name == BonePart.name){
	    snapaudio.Play();
	    insideSnapZone = true;
        Snapped = true;
        }
    }

    private void OnTriggerExit(Collider other){
	//Debug.Log("other.gameObject.name=" + other.gameObject.name + "====");
	//Debug.Log("BonePart.name=" + BonePart.name + "====");
	if (other.gameObject.name == BonePart.name){
	    insideSnapZone = false;
	}
    }

    void snapObject(){
	if (grabbed == false && insideSnapZone == true){
	    //BonePart.gameObject.transform.GetChild(3).transform.position = transform.position;
	    BonePart.gameObject.transform.position = transform.position;
	    BonePart.gameObject.transform.rotation = SnapRotationReference.transform.rotation;
	    Snapped = true;
			
	}

    }

    // Start is called before the first frame update
    void Start(){
	//Debug.Log("Running SnapObj.cs...");
	snapaudio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update(){
        grabbed = BonePart.GetComponent<OVRGrabbable>().isGrabbed;
        snapObject();
    }
}
