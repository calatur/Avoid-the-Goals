using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public count fs;
    public Text txt;
   
    private void Start()
    {
        fs = FindAnyObjectByType<count>();

        txt.text = count.fscore.ToString() + " Coins collected";
    }
    public void play()
    {
        SceneManager.LoadScene("SampleScene"); }

    public void quit()
    {
        Application.Quit();
    }
}
