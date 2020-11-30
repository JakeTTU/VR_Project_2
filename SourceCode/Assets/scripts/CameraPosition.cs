using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraPosition : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool gameStart = false;
    public static bool restartGame = false;
    public static string level = "";


    public Button yourButton;

    public GameObject gameSelected;
    public GameObject gameDeselect1;
    public GameObject gameDeselect2;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {

        //game selection
        gameSelected.SetActive(true);
        gameDeselect1.SetActive(false);
        gameDeselect2.SetActive(false);

        level = gameSelected.name;

        // set game status to start the timer
        gameStart = true;
        restartGame = true;


    }


}
