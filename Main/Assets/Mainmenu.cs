using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{ 

    public void playnextgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } 

    public void Quitgame()
    {
        Debug.Log ("QUIT!"); 
        Application.Quit();
    }
}
