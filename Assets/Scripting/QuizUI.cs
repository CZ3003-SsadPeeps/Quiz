using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    //public Button yourButton;
    public Button btn;
    


    void Start()
    {
        this.GetComponentInChildren<Text>().text = "Correct Answer";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            this.GetComponent<Image>().color = Color.green;
        }
        

    }

    void TaskOnClick()
    {
        
        Debug.Log("You have clicked the buttonA!");
    }
}
