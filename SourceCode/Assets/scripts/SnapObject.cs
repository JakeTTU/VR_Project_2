using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour
{

	public GameObject SnapLocation;

	public GameObject bone;


	public bool isSnapped;

	private bool objectSnapped;

	private bool grabbed;





    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Running SnapObject.cs...");
    }

    // Update is called once per frame
    void Update()
    {
        grabbed = GetComponent<OVRGrabbable>().isGrabbed;

	objectSnapped = SnapLocation.GetComponent<SnapToLocation>().Snapped;

	if (objectSnapped == true){
		GetComponent<Rigidbody>().isKinematic = true;
		transform.SetParent(bone.transform);
		isSnapped = true;
	}

	if (objectSnapped == false && grabbed == false){
		GetComponent<Rigidbody>().isKinematic = false;
	}


    }
}


