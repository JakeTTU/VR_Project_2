using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

{
    public bool isFinished = false;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject go = GameObject.Find("Ribs");
        //print(go.name + " has " + go.transform.childCount + " children");

  
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag(CameraPosition.level);
        foreach (GameObject obj in objs)
        {
            if (obj.GetComponent<SnapToLocation>().Snapped == false)
            {
                // isFinished = false;
                // return isFinished
            }
            else
            {
                print("TRUE");
            }
        }

        isFinished = true;
    }
}
