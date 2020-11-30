using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextDisplay : MonoBehaviour
{

    private bool grabbed;

     
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GameController")
        {
            this.gameObject.transform.Find("Display/Text").gameObject.SetActive(true);
            this.gameObject.transform.Find("Display/Text").gameObject.GetComponent<UnityEngine.UI.Text>().text = this.gameObject.name;
        }
     

       
       
    }

    private void OnTriggerExit(Collider other)
   {
      

        this.gameObject.transform.Find("Display/Text").gameObject.SetActive(false);
        this.gameObject.transform.Find("Display/Text").gameObject.GetComponent<UnityEngine.UI.Text>().text = "";

        
    }

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.Find("Display/Text").gameObject.SetActive(false);
    
    }

    // Update is called once per frame
    void Update()
    {
    

    }
}


