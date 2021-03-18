using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitButtonScript : MonoBehaviour
{
    //public Button bttn;
    
    public void BackBtt()
    {
        this.GetComponent<Button>().onClick.AddListener(backToGame);
    }

    public void backToGame()
    {
        Debug.Log("selected");
        SceneManager.LoadScene("DifficultySelection");
    }
}
